using UnityEngine;

public class IntimacyTouchEffect : MonoBehaviour
{
	[SerializeField]
	private ParticleSystem m_effectBeggin;
	[SerializeField]
	private ParticleSystem m_effectEnd;
	[SerializeField]
	private Camera m_systemCanvasCamera;
	private void Awake()
	{
		TodoLogger.Log(0, "Implement Monobehaviour");
	}
}
