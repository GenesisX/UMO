using XeSys.Gfx;
using System.Collections.Generic;
using UnityEngine;
using XeApp.Game;

namespace XeApp.Game.Menu
{
	public class LayoutEventGoDivaAttrFrame : LayoutUGUIScriptBase
	{
    public void Awake() { UnityEngine.Debug.LogError("Immplement LayoutUGUIScriptBase"); }
		[SerializeField]
		private List<RawImageEx> m_frameImages;
		[SerializeField]
		private TextureListSupport m_texListSupport;
	}
}
