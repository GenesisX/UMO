using UnityEngine;
using System;
using System.Collections;
using UnityEngine.Playables;

namespace XeApp.Game.Common
{
	public class GameValkyrieObject : ValkyrieObject
	{
		protected static readonly int EnterStateHash = Animator.StringToHash("Begin"); // 0x0
		protected static readonly int MainStateHash = Animator.StringToHash("Main"); // 0x4
		protected static readonly int DamageStateHash = Animator.StringToHash("Damage"); // 0x8
		protected static readonly int TransformStateHash = Animator.StringToHash("Transform"); // 0xC
		protected static readonly int BattroidMainStateHash = Animator.StringToHash("BattroidMain"); // 0x10
		protected static readonly int BattroidDamageStateHash = Animator.StringToHash("BattroidDamage"); // 0x14
		protected static readonly int EndStateHash = Animator.StringToHash("End"); // 0x18
		protected static readonly int TransformParamStateHash = Animator.StringToHash("isTranform"); // 0x1C
		private double m_animationBaseTime = -1; // 0x40
		private bool m_resetAnimationBaseTime; // 0x48
		private bool m_isPause; // 0x49
		private Coroutine m_coWaitDamageEnd; // 0x4C
		private Func<string> m_getHitEffectName; // 0x58
		private bool m_shootOnlyOnce; // 0x5C
		private bool m_isShooted; // 0x5D

		// protected override bool usingEffectFactory { get; } 0xEA07B8
		// protected override bool usingQualitySetting { get; } 0xEA07C0
		private bool isDamage { get; set; } // 0x50
		public bool isShootLock { get; private set; } // 0x51
		private bool isShootTiming { get; set; } // 0x52
		private bool isShooting { get; set; } // 0x53
		private bool isTransforming { get; set; } // 0x54

		// // RVA: 0xEA0818 Offset: 0xEA0818 VA: 0xEA0818 Slot: 7
		// protected override void OnInitialize(ValkyrieResource resource) { }

		// // RVA: 0xEA0D40 Offset: 0xEA0D40 VA: 0xEA0D40 Slot: 8
		// protected override void OnRelease() { }

		// // RVA: 0xEA0D44 Offset: 0xEA0D44 VA: 0xEA0D44
		// public void ResetAnimationBaseTime() { }

		// // RVA: 0xEA0D50 Offset: 0xEA0D50 VA: 0xEA0D50
		public void ChangeAnimationTime(double time)
		{
			if(m_resetAnimationBaseTime)
			{
				m_animationBaseTime = time;
				m_resetAnimationBaseTime = false;
			}
			if(gameObject.activeSelf)
			{
				animator.speed = 1;
				if (PlayableExtensions.IsValid<Playable>(animator.playableGraph.GetRootPlayable(0)))
				{
					animator.playableGraph.Evaluate((float)(time - m_animationBaseTime - PlayableExtensions.GetTime<Playable>(animator.playableGraph.GetRootPlayable(0))));
				}
			}
			if(effectFactories != null)
			{
				effectFactories.ChangeAnimationTime(time);
			}
		}

		// // RVA: 0xEA0F64 Offset: 0xEA0F64 VA: 0xEA0F64
		// public void Pause() { }

		// // RVA: 0xEA1044 Offset: 0xEA1044 VA: 0xEA1044
		// public void Resume() { }

		// // RVA: 0xEA11C0 Offset: 0xEA11C0 VA: 0xEA11C0
		// public void StartEnterAnimation(bool isDebug) { }

		// // RVA: 0xEA1398 Offset: 0xEA1398 VA: 0xEA1398
		// public void StartMainAnimation() { }

		// // RVA: 0xEA146C Offset: 0xEA146C VA: 0xEA146C
		// public void StartLeaveAnimation() { }

		// // RVA: 0xEA157C Offset: 0xEA157C VA: 0xEA157C
		// public void StartTransformAnimation() { }

		// // RVA: 0xEA176C Offset: 0xEA176C VA: 0xEA176C
		// public void SetShootLock(bool isLock) { }

		// // RVA: 0xEA1760 Offset: 0xEA1760 VA: 0xEA1760
		// public void ForceShootStop() { }

		// // RVA: 0xEA1780 Offset: 0xEA1780 VA: 0xEA1780
		// private void OnShootStartEvent() { }

		// // RVA: 0xEA1774 Offset: 0xEA1774 VA: 0xEA1774
		// private void OnShootStopEvent() { }

		// // RVA: 0xEA178C Offset: 0xEA178C VA: 0xEA178C
		// private void OnShootSingleEvent() { }

		// // RVA: 0xEA112C Offset: 0xEA112C VA: 0xEA112C
		// private void CheckShootAction() { }

		// // RVA: 0xEA1790 Offset: 0xEA1790 VA: 0xEA1790
		// private void CheckSingleShoot() { }

		// // RVA: 0xEA1834 Offset: 0xEA1834 VA: 0xEA1834
		// private void ShootStart() { }

		// // RVA: 0xEA1B94 Offset: 0xEA1B94 VA: 0xEA1B94
		// private void ShootStop() { }

		// // RVA: 0xEA1CFC Offset: 0xEA1CFC VA: 0xEA1CFC
		// public string GetHitEffectName() { }

		// // RVA: 0xEA1D74 Offset: 0xEA1D74 VA: 0xEA1D74
		// public void DamageStart() { }

		// [IteratorStateMachineAttribute] // RVA: 0x73C090 Offset: 0x73C090 VA: 0x73C090
		// // RVA: 0xEA1F8C Offset: 0xEA1F8C VA: 0xEA1F8C
		// private IEnumerator Co_WaitDamageEffectProcess() { }

		// // RVA: 0xEA2038 Offset: 0xEA2038 VA: 0xEA2038
		// public void DamageStop() { }

		// // RVA: 0xEA20F4 Offset: 0xEA20F4 VA: 0xEA20F4
		public void SetOverrideAnimationIntro(MusicIntroResource a_resource)
		{
			TodoLogger.Log(0, "ValkyrieObject SetOverrideAnimationIntro");
		}

		// [CompilerGeneratedAttribute] // RVA: 0x73C108 Offset: 0x73C108 VA: 0x73C108
		// // RVA: 0xEA24C8 Offset: 0xEA24C8 VA: 0xEA24C8
		// private void <StartTransformAnimation>b__48_0() { }

		// [CompilerGeneratedAttribute] // RVA: 0x73C118 Offset: 0x73C118 VA: 0x73C118
		// // RVA: 0xEA24D4 Offset: 0xEA24D4 VA: 0xEA24D4
		// private void <DamageStart>b__59_0() { }
	}
}
