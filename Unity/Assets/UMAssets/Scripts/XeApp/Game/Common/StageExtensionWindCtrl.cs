using System.Collections.Generic;
using UnityEngine;
using XeSys;

namespace XeApp.Game.Common
{
	public class StageExtensionWindCtrl : StageExtensionObjectComponentBase
	{
		public class NodeInfo
		{
			public Vector3 m_prev = new Vector3(0, 0, 0); // 0x8
			public Vector3 m_next = new Vector3(0, 0, 0); // 0x14
			public Vector3 m_now = new Vector3(0, 0, 0); // 0x20
			public Transform m_trans; // 0x2C
			public float m_rate; // 0x30
		}

		public class DivaInfo
		{
			public DivaObject m_diva; // 0x8
			public BoneSpringController m_bsc; // 0xC
			public List<StageExtensionWindCtrl.NodeInfo> m_node; // 0x10
		}

		[SerializeField]
		public float m_power; // 0xC
		[SerializeField]
		public Vector3 m_wind_dir = new Vector3(0, 0, 0); // 0x10
		[SerializeField]
		public Vector2 m_rand_x = new Vector2(0, 0); // 0x1C
		[SerializeField]
		public Vector2 m_rand_y = new Vector2(0, 0); // 0x24
		[SerializeField]
		public float m_sub_power; // 0x2C
		[SerializeField]
		public Vector2 m_sub_rand_x = new Vector2(0, 0); // 0x30
		[SerializeField]
		public Vector2 m_sub_rand_y = new Vector2(0, 0); // 0x38
		[RangeAttribute(0, float.MaxValue)] // RVA: 0x687CD0 Offset: 0x687CD0 VA: 0x687CD0
		[SerializeField]
		public float m_interval; // 0x40
		[SerializeField]
		public float m_speed; // 0x44
		protected List<StageExtensionWindCtrl.DivaInfo> m_list_diva = new List<StageExtensionWindCtrl.DivaInfo>(); // 0x48
		private float m_frame; // 0x4C
		private float m_frame_rate = 1; // 0x50
		private Vector3 m_now_dir = new Vector3(0, 0, 0); // 0x54
		private Vector3 m_next_dir = new Vector3(0, 0, 0); // 0x60
		private Vector3 m_prev_dir = new Vector3(0, 0, 0); // 0x6C
		public bool m_pause; // 0x78

		// public List<StageExtensionWindCtrl.DivaInfo> listDiva { get; private set; } 0x13A4F30 0x13A4F38

		// // RVA: 0x13A1288 Offset: 0x13A1288 VA: 0x13A1288
		public void Initialize(List<GameDivaObject> a_list_diva)
		{
			List<DivaObject> divas = new List<DivaObject>();
			for(int i = 0; i < a_list_diva.Count; i++)
			{
				divas.Add(a_list_diva[i]);
			}
			Initialize(divas);
		}

		// // RVA: 0x13A4F3C Offset: 0x13A4F3C VA: 0x13A4F3C
		public void Initialize(List<DivaObject> a_list_diva)
		{
			m_list_diva.Clear();
			for(int i = 0; i < a_list_diva.Count; i++)
			{
				DivaInfo info = new DivaInfo();
				info.m_diva = a_list_diva[i];
				info.m_bsc = info.m_diva.divaPrefab.GetComponentInChildren<BoneSpringController>(true);
				info.m_node = CreateNodeInfo(info.m_bsc);
				m_list_diva.Add(info);
			}
			m_now_dir = Vector3.zero;
			m_next_dir = Vector3.zero;
			m_prev_dir = Vector3.zero;	
		}

		// // RVA: 0x13A19FC Offset: 0x13A19FC VA: 0x13A19FC
		// public void AddExtensionBSC(List<BoneSpringController> a_list_bsc) { }

		// // RVA: 0x13A5190 Offset: 0x13A5190 VA: 0x13A5190
		private List<StageExtensionWindCtrl.NodeInfo> CreateNodeInfo(BoneSpringController a_bsc)
		{
			List<StageExtensionWindCtrl.NodeInfo> res = new List<StageExtensionWindCtrl.NodeInfo>();
			List<BoneSpringControlPoint> cplist = a_bsc.GetListBSCP();
			for(int i = 0; i < cplist.Count; i++)
			{
				NodeInfo info = new NodeInfo();
				info.m_trans = cplist[i].gameObject.transform;
				res.Add(info);
			}
			return res;
		}

		// // RVA: 0x13A541C Offset: 0x13A541C VA: 0x13A541C Slot: 6
		public virtual void Update()
		{
			UnityEngine.Debug.LogError("TODO Wind Update");
		}

		// // RVA: 0x13A6030 Offset: 0x13A6030 VA: 0x13A6030 Slot: 4
		// public override void Pause() { }

		// // RVA: 0x13A603C Offset: 0x13A603C VA: 0x13A603C Slot: 5
		// public override void Resume() { }
	}
}
