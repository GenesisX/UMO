using UnityEngine.UI;
using UnityEngine;

public class CharacterSpacing : BaseMeshEffect
{
	private void Awake()
	{
		TodoLogger.Log(0, "Implement monobehaviour");
	}
	public override void ModifyMesh(VertexHelper vh)
	{
	}

	[SerializeField]
	private float m_Offset;
}
