using UnityEngine;
using UnityEditor;

public class DragonAssetCreatorEditor
{
    [MenuItem("Assets/Create/DragonData")]
    public static void CreateAsset()
    {
       ScriptableObjectCreatorEditor.CreateAsset<DragonData>("DragonData");
    }
}
