using UnityEngine.UI;
using UnityEngine;

public class ToJShadow : BaseMeshEffect
{
	private void Awake()
	{
		TodoLogger.Log(0, "Implement monobehaviour");
	}
	public override void ModifyMesh(VertexHelper vh)
	{
	}

	[SerializeField]
	private Color m_EffectColor;
	[SerializeField]
	private Vector2 m_EffectDistance;
	[SerializeField]
	private bool m_UseGraphicAlpha;
}
