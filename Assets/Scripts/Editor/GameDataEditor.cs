using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using UnityEditor;

public class ScienceGameDataEditor : EditorWindow
{
    public ScienceGameData gameData;

    private string gameDataProjectFilePath = "/StreamingAsset/data.json";

    [MenuItem ("Window/Game Data Editor")]
    static void Init()
    {
        ScienceGameDataEditor window = (ScienceGameDataEditor)EditorWindow.GetWindow(typeof(ScienceGameDataEditor));
        window.Show();
    }

    void OnGUI()
    {
        if (gameData != null)
        {
            SerializedObject serializedObject = new SerializedObject(this);
            SerializedProperty serializedProperty = serializedObject.FindProperty("gameData");

            EditorGUILayout.PropertyField(serializedProperty,true);

            serializedObject.ApplyModifiedProperties();

            if (GUILayout.Button("Save data"))
            {
                SaveGameData();
            }
        }
        if (GUILayout.Button("Load data"))
        {
            LoadGameData();
        }
    
    }
    private void LoadGameData()
    {
        string filePath = Application.dataPath + gameDataProjectFilePath;

        if (File.Exists(filePath))
        {
            string dataAsJson = File.ReadAllText(filePath);
            gameData = JsonUtility.FromJson<ScienceGameData>(dataAsJson);
        }
        else
        {
            gameData = new ScienceGameData();
        }
    }

    private void SaveGameData()
    {
        string dataAsJson = JsonUtility.ToJson(gameData);
        string filePath = Application.dataPath + gameDataProjectFilePath;
        File.WriteAllText(filePath, dataAsJson);
    }

}
