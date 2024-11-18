using UnityEditor;
using UnityEngine;
using System.Collections;

[InitializeOnLoad]
public class AutoSave
{
    static AutoSave()
    {
        EditorApplication.update += Update;
    }

    static void Update()
    {
        if (Time.realtimeSinceStartup % 300 < 1) // Autosave every 5 minutes (300 seconds)
        {
            Debug.Log("Autosaving...");
            EditorApplication.ExecuteMenuItem("File/Save Scenes");
        }
    }
}
