using XeApp.Core;
using UnityEngine;

namespace XeApp.Game.RhythmGame.UI
{
	public class BattleEvaluateObject : PoolObject
	{
		[SerializeField]
		private Animator _animator; // 0x14
		// private static readonly int[] AnimationHashTable; // 0x0

		// // RVA: 0x15592D0 Offset: 0x15592D0 VA: 0x15592D0
		// public void SetValkyrieOffPriority() { }

		// // RVA: 0x155968C Offset: 0x155968C VA: 0x155968C
		// public void Play(int index) { }

		// // RVA: 0x155978C Offset: 0x155978C VA: 0x155978C
		// public bool IsPlaying() { }

		// RVA: 0x1559820 Offset: 0x1559820 VA: 0x1559820 Slot: 5
		protected override void PausableAwake()
		{
			UnityEngine.Debug.LogError("TODO");
		}

		// RVA: 0x1559824 Offset: 0x1559824 VA: 0x1559824 Slot: 6
		protected override void PausableStart()
		{
			UnityEngine.Debug.LogError("TODO");
		}

		// RVA: 0x1559828 Offset: 0x1559828 VA: 0x1559828 Slot: 7
		protected override void PausableUpdate()
		{
			UnityEngine.Debug.LogError("TODO");
		}

		// RVA: 0x155982C Offset: 0x155982C VA: 0x155982C Slot: 8
		protected override void PausableInPause()
		{
			UnityEngine.Debug.LogError("TODO");
		}

		// RVA: 0x1559838 Offset: 0x1559838 VA: 0x1559838
		static BattleEvaluateObject()
		{
			UnityEngine.Debug.LogError("TODO static BattleEvaluateObject");
		}
	}
}
