using UnityEngine;
using XeSys.Gfx;

namespace XeApp.Game.Menu
{
	public class SceneImageViewer : MonoBehaviour
	{
		[SerializeField]
		private SceneViewerArrow leftArrow;
		[SerializeField]
		private SceneViewerArrow rightArrow;
		[SerializeField]
		private RawImageEx m_kiraEffectImage;
		[SerializeField]
		private RawImageEx m_kiraOverlayEffectImage;
		private void Awake()
		{
			TodoLogger.Log(0, "Implement Monobehaviour");
		}
	}
}
