using UnityEngine;
using XeApp.Game.Common;

public static class TodoLogger
{
	public static void Log(int priority, string str)
	{
		if(priority < RuntimeSettings.CurrentSettings.MinLog)
		{
			UnityEngine.Debug.LogError(str);
		}
	}
	public static void LogNotImplemented(string str)
	{
		TextPopupSetting s = new TextPopupSetting();
		s.TitleText = "Not Implemented";
		s.Text = "Not implemented\n"+str;
		s.WindowSize = SizeType.Large;
		s.Buttons = new ButtonInfo[1] { new ButtonInfo() { Label = PopupButton.ButtonLabel.Ok, Type = PopupButton.ButtonType.Positive } };
		UnityEngine.Debug.LogError("Not Implemented " + str);
		PopupWindowManager.Show(s, null, null, null, null);
	}
}
