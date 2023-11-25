using UnityEngine;
using System.Collections;
using System.IO;
using System;

public class UMOLogWritter : MonoBehaviour
{
    FileStream logFile;
    StreamWriter sw;
    bool filecreated = false;
    bool starting = true;

    static public UMOLogWritter Instance { private set; get; }

    void OnEnable()
    {
        Instance = this;
        try
        {
            if(!filecreated)
            {
                logFile = new FileStream(Application.persistentDataPath+"/Log.txt", FileMode.Create);
                sw = new StreamWriter(logFile);
                filecreated = true;
            }
        } catch(Exception e)
        {
            UnityEngine.Debug.LogException(e);
            filecreated = false;
        }
        if(filecreated)
        {
            Application.logMessageReceived += HandleLog;
        }
    }

    void OnDisable()
    {
        Application.logMessageReceived -= HandleLog;
    }

    public void CheckEnabled()
    {
        starting = false;
        enabled = RuntimeSettings.CurrentSettings.EnableInfoLog || RuntimeSettings.CurrentSettings.EnableErrorLog;
    }

    void HandleLog(string logString, string stackTrace, LogType type)
    {
        if(!starting)
        {
            if(!RuntimeSettings.CurrentSettings.EnableInfoLog && (type == LogType.Log || type == LogType.Warning))
                return;
            if(!RuntimeSettings.CurrentSettings.EnableErrorLog && type != LogType.Log && type != LogType.Warning)
                return;
        }
        sw.Write("["+type+"] "+logString);
        sw.Write(stackTrace);
        sw.Write("\n\n");
        sw.Flush();
        logFile.Flush();
    }
}