namespace XeApp.Game
{
	public class DebugCheatUI_CrashLog : DebugCheatUI_SystemsBase
	{
		private void Awake()
		{
			TodoLogger.LogError(0, "Implement monobehaviour");
		}
	}
}
