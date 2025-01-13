using UnityEditor;
using UnityEngine;
using System.IO;

public class CreateDefaultFolders : EditorWindow
{
    [MenuItem("Tools/Create Default Folders")]
    public static void CreateFolders()
    {
        string[] folders = new string[]
        {
            "Scripts",
            "Scripts/Core",
            "Scripts/Core/Input",
            "Scripts/Core/Managers",
            "Scripts/Core/Utilities",
            "Scripts/Core/ScriptableObjects",
            "Scripts/Features",
            "Scripts/Features/Player",
            "Scripts/Features/Enemies",
            "Scripts/Features/Items",
            "Scripts/Features/UI",
            "Scripts/Systems",
            "Scripts/Systems/SaveSystem",
            "Scripts/Systems/DialogueSystem",
            "Scripts/Systems/AudioSystem",
            "Scripts/Systems/EventSystem",
            "Scripts/Tests",
            "Scripts/Tests/PlayMode",
            "Scripts/Tests/EditMode",
            "Art",
            "Art/Textures",
            "Art/Materials",
            "Art/Models",
            "Art/Animations",
            "Prefabs",
            "Scenes",
            "Audio",
            "Audio/Music",
            "Audio/SFX",
            "UI",
            "UI/Fonts",
            "UI/Sprites",
            "VFX"
        };

        foreach (string folder in folders)
        {
            string folderPath = Path.Combine(Application.dataPath, folder);
            if (!Directory.Exists(folderPath))
            {
                Directory.CreateDirectory(folderPath);
            }
        }

        AssetDatabase.Refresh();
        Debug.Log("Default folders created successfully!");
    }
} 