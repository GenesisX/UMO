using System;
using System.Collections;
using System.Collections.Generic;
using CriWare;
using UnityEngine;
using UnityEngine.Playables;
using XeApp.Core;

namespace XeApp.Game.Common
{
	public class ValkyrieModeObject : MonoBehaviour
	{
		private static readonly int EnterStateHash = ValkyrieModeMotionRef.EnterStateHash; // 0x0
		private static readonly int MainStateHash = ValkyrieModeMotionRef.MainStateHash; // 0x4
		private static readonly int LeaveStateHash = ValkyrieModeMotionRef.LeaveStateHash; // 0x8
		private static readonly int FailedStateHash = ValkyrieModeMotionRef.FailedStateHash; // 0xC
		private static readonly int ExEnterStateHash = ValkyrieModeMotionRef.ExEnterStateHash; // 0x10
		[SerializeField]
		private Camera m_musicCamera; // 0xC
		[SerializeField]
		private Camera m_modeCamera; // 0x10
		[SerializeField]
		private GameValkyrieObject m_valkyrie; // 0x14
		private GameObject m_mainObj; // 0x18
		private ValkyrieModeMotionRef m_refData; // 0x1C
		private ValkyrieModeEventListener m_eventListener; // 0x20
		private EffectFactoryBase m_effectFactory; // 0x24
		private ValkyrieModeLockOnTarget m_lockOnTarget; // 0x28
		private List<Renderer> m_renderers = new List<Renderer>(16); // 0x2C
		private List<Animator> m_animators = new List<Animator>(3); // 0x30
		private double m_animationBaseTime = -1; // 0x38
		private bool m_resetAnimationBaseTime; // 0x40
		private bool m_isFailed; // 0x41
		private Coroutine m_coWaitForEnterEnd; // 0x44
		private Coroutine m_coWaitForAnimationEnd; // 0x48
		private CriAtomExPlayback m_flightSePlayback; // 0x4C
		private List<ParticleSystem> m_list_particle = new List<ParticleSystem>(); // 0x50
		private bool isInitialized; // 0x54
		private bool isHitEffect; // 0x55

		public Action onBeginShooting { private get; set; } // 0x58
		public Action onEndAnimationCallback { private get; set; } // 0x5C
		public Action onPlayerCutInStart { set { 
			m_eventListener.onPlayerCutInStart = value;
		} } //0x1CE31EC
		public Action onEnemyCutInStart { set { 
			m_eventListener.onEnemyCutInStart = value; 
		} } //0x1CE3214
		public Action onEnemyLockOnStart { set { 
			m_eventListener.onEnemyLockOnStart = value;
		} } //0x1CE323C
		public bool isRunning { get; private set; } // 0x60
		public bool isShootingPhase { get; private set; } // 0x61
		public bool isPause { get; private set; } // 0x62

		// RVA: 0x1CE31C8 Offset: 0x1CE31C8 VA: 0x1CE31C8
		//public void ResetAnimationPreview() { }

		// RVA: 0x1CE3294 Offset: 0x1CE3294 VA: 0x1CE3294
		private void Awake()
		{
			return;
		}

		// RVA: 0x1CE3298 Offset: 0x1CE3298 VA: 0x1CE3298
		private void OnDestroy()
		{
			TodoLogger.Log(0, "ValkyrieMode Object OnDestroy");
		}

		// RVA: 0x1CE32A8 Offset: 0x1CE32A8 VA: 0x1CE32A8
		public void Initialize(ValkyrieModeResource resource, bool isDebug = false)
		{
			InstantiatePrefab(resource);
			MakeCameraParent();
			m_animators.Clear();
			for (int i = 0; i < m_refData.animationDataNum; i++)
			{
				m_animators.Add(m_refData.GetAnimationData(i).animator);
			}
			for(int i = 0; i < m_renderers.Count; i++)
			{
				m_renderers[i].enabled = true;
			}
			m_modeCamera.enabled = false;
			for(int i = 0; i < m_animators.Count; i++)
			{
				m_animators[i].enabled = false;
				m_animators[i].playableGraph.SetTimeUpdateMode(UnityEngine.Playables.DirectorUpdateMode.Manual);
			}
			m_list_particle.Clear();
			m_list_particle.AddRange(m_mainObj.GetComponentsInChildren<ParticleSystem>(true));
			StartCoroutine(Co_DelayInit());
		}

		//[IteratorStateMachineAttribute] // RVA: 0x73C828 Offset: 0x73C828 VA: 0x73C828
		//// RVA: 0x1CE3C64 Offset: 0x1CE3C64 VA: 0x1CE3C64
		private IEnumerator Co_DelayInit()
		{
			//0xD2645C
			SetAllActive(true);
			yield return null;
			SetAllActive(false);
			yield return null;
			for(int i = 0; i < m_renderers.Count; i++)
			{
				m_renderers[i].enabled = false;
			}
		}

		//// RVA: 0x1CE3CEC Offset: 0x1CE3CEC VA: 0x1CE3CEC
		public void Begin(bool isDebug = false)
		{
			if(m_coWaitForEnterEnd != null)
			{
				StopCoroutine(m_coWaitForEnterEnd);
			}
			if(m_coWaitForAnimationEnd != null)
			{
				StopCoroutine(m_coWaitForAnimationEnd);
			}
			SetAllActive(true);
			isRunning = true;
			isShootingPhase = false;
			m_valkyrie.StartEnterAnimation(isDebug);
			for(int i = 0; i < m_animators.Count; i++)
			{
				if(!m_refData.GetAnimationData(i).hasEnter)
				{
					m_animators[i].Play(MainStateHash, 0, 0.0f);
				}
				else
				{
					m_animators[i].Play(EnterStateHash, 0, 0.0f);
				}
			}
			m_resetAnimationBaseTime = true;
			m_coWaitForEnterEnd = StartCoroutine(Co_WaitForEnterEnd());
			m_lockOnTarget.Register(m_valkyrie.instance.transform);
			isInitialized = true;
			m_isFailed = false;
		}

		//// RVA: 0x1CE42B4 Offset: 0x1CE42B4 VA: 0x1CE42B4
		public void SetFailed(bool failed)
		{
			m_isFailed = failed;
		}

		//// RVA: 0x1CE42BC Offset: 0x1CE42BC VA: 0x1CE42BC
		//public void SetShootLock(bool isLock) { }

		//// RVA: 0x1CE42F0 Offset: 0x1CE42F0 VA: 0x1CE42F0
		public void Leave()
		{
			!!!
		}

		//// RVA: 0x1CE4704 Offset: 0x1CE4704 VA: 0x1CE4704
		//public void End() { }

		//// RVA: 0x1CE47E4 Offset: 0x1CE47E4 VA: 0x1CE47E4
		//public void Pause() { }

		//// RVA: 0x1CE4A4C Offset: 0x1CE4A4C VA: 0x1CE4A4C
		//public void Resume() { }

		//// RVA: 0x1CE4CE0 Offset: 0x1CE4CE0 VA: 0x1CE4CE0
		//public void GetLockOnTargetPos(out Vector2 result) { }

		//// RVA: 0x1CE4DA4 Offset: 0x1CE4DA4 VA: 0x1CE4DA4
		//public void GetLockOnTargetPos(out Vector3 result) { }

		//// RVA: 0x1CE4EC0 Offset: 0x1CE4EC0 VA: 0x1CE4EC0
		//public void NotifyHit() { }

		//// RVA: 0x1CE4F64 Offset: 0x1CE4F64 VA: 0x1CE4F64
		//public void NotifyDamage() { }

		//// RVA: 0x1CE4220 Offset: 0x1CE4220 VA: 0x1CE4220
		//private void ResetAnimationBaseTime() { }

		//// RVA: 0x1CE4F9C Offset: 0x1CE4F9C VA: 0x1CE4F9C
		public void ChangeAnimationTime(double time)
		{
			if(m_resetAnimationBaseTime)
			{
				m_animationBaseTime = time;
				m_resetAnimationBaseTime = false;
			}
			if(isRunning)
			{
				for(int i = 0; i < m_animators.Count; i++)
				{
					m_animators[i].speed = 1;
					if (PlayableExtensions.IsValid<Playable>(m_animators[i].playableGraph.GetRootPlayable(0)))
					{
						m_animators[i].playableGraph.Evaluate((float)(time - m_animationBaseTime - PlayableExtensions.GetTime<Playable>(m_animators[i].playableGraph.GetRootPlayable(0))));
					}
				}
				m_effectFactory.ChangeAnimationTime(time);
				m_valkyrie.ChangeAnimationTime(time);
				isHitEffect = false;
			}
		}

		//// RVA: 0x1CE401C Offset: 0x1CE401C VA: 0x1CE401C
		private void SetAllActive(bool active)
		{
			m_musicCamera.enabled = !active;
			m_valkyrie.Activate(active);
			m_modeCamera.enabled = active;
			for(int i = 0; i < m_animators.Count; i++)
			{
				m_animators[i].enabled = active;
			}
			for(int i = 0; i < m_renderers.Count; i++)
			{
				m_renderers[i].enabled = active;
			}
			m_effectFactory.Setup();
		}

		//// RVA: 0x1CE3660 Offset: 0x1CE3660 VA: 0x1CE3660
		private void InstantiatePrefab(ValkyrieModeResource resource)
		{
			Destroy(m_mainObj);
			m_refData = null;
			m_mainObj = Instantiate<GameObject>(resource.mainPrefab);
			m_mainObj.transform.SetParent(transform, false);
			m_refData = m_mainObj.GetComponent<ValkyrieModeMotionRef>();
			m_eventListener = m_mainObj.GetComponentInChildren<ValkyrieModeEventListener>(true);
			m_effectFactory = m_mainObj.GetComponent<EffectFactoryBase>();
			m_effectFactory.Instantiate();
			m_lockOnTarget = m_refData.shootToTarget.gameObject.AddComponent<ValkyrieModeLockOnTarget>();
			if(resource.changeCameraBeginAnimClip != null)
			{
				Animator[] anims = m_mainObj.GetComponentsInChildren<Animator>();
				for(int i = 0; i < anims.Length; i++)
				{
					if(anims[i].name == "battle_cam")
					{
						AnimatorOverrideController animOverride = new AnimatorOverrideController();
						animOverride.name = "override_battle_cam";
						animOverride.runtimeAnimatorController = anims[i].runtimeAnimatorController;
						animOverride["battle_G_start_cam"] = resource.changeCameraBeginAnimClip;
						anims[i].runtimeAnimatorController = animOverride;
					}
				}
			}
			m_renderers.Clear();
			m_renderers.AddRange(m_mainObj.GetComponentsInChildren<Renderer>(true));
		}

		//// RVA: 0x1CE3B58 Offset: 0x1CE3B58 VA: 0x1CE3B58
		private void MakeCameraParent()
		{
			m_modeCamera.transform.SetParent(m_refData.cameraRoot, false);
			m_refData.cameraRoot.gameObject.AddComponent<MayaCameraConverter>();
		}

		//[IteratorStateMachineAttribute] // RVA: 0x73C8A0 Offset: 0x73C8A0 VA: 0x73C8A0
		//// RVA: 0x1CE422C Offset: 0x1CE422C VA: 0x1CE422C
		private IEnumerator Co_WaitForEnterEnd()
		{
			//0xD26A90
			yield return new WaitForSeconds(0.5f);
			while (true)
			{
				AnimatorStateInfo info = m_valkyrie.animator.GetCurrentAnimatorStateInfo(0);
				if (info.normalizedTime >= 1)
				{
					break;
				}
				yield return null;
			}
			m_valkyrie.StartMainAnimation();
			for(int i = 0; i < m_animators.Count; i++)
			{
				if(m_refData.GetAnimationData(i).hasEnter)
				{
					while (true)
					{
						AnimatorStateInfo info = m_animators[i].GetCurrentAnimatorStateInfo(0);
						if (info.normalizedTime >= 1)
							break;
						yield return null;
					}
					m_animators[i].Play(MainStateHash, 0, 0.0f);
				}
			}
			isShootingPhase = true;
			if (onBeginShooting != null)
				onBeginShooting();
			m_lockOnTarget.Begin(3.0f);
			m_flightSePlayback = SoundManager.Instance.sePlayerGame.Play(13);
		}

		//[IteratorStateMachineAttribute] // RVA: 0x73C918 Offset: 0x73C918 VA: 0x73C918
		//// RVA: 0x1CE467C Offset: 0x1CE467C VA: 0x1CE467C
		//private IEnumerator Co_WaitForAnimationEnd() { }
	}
}
