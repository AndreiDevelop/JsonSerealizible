using UnityEngine;
using UnityEditor;
using System.IO;

public class ScriptableObjectCreatorEditor
{
    public static void CreateAsset<T> (string assetName) where T : ScriptableObject 
    {
        #if UNITY_EDITOR
        //создаем экземпляр типа Т
        T asset = ScriptableObject.CreateInstance<T>();

        //получаем путь текущего объекта
        string path = AssetDatabase.GetAssetPath(Selection.activeObject);

        if (string.IsNullOrEmpty(path))
            path = "Assets";
        //если путь текущего объекта известен
        else if (Path.GetExtension(path) != "")
            //заменяем все предыдущие вхождения строки на новое значение
            path = path.Replace(Path.GetFileName(AssetDatabase.GetAssetPath(Selection.activeObject)), "");

        //создаем новый путь в котором будет храниться ассет
        string assetPathAndName = AssetDatabase.GenerateUniqueAssetPath(path + "/" + assetName + ".asset");

        //создаем новый ассет по указанному пути
        AssetDatabase.CreateAsset(asset, assetPathAndName);

        //сохраняем все несохраненные изменения ассетов на диск
        AssetDatabase.SaveAssets();

        //обновляем
        AssetDatabase.Refresh();

        #endif
    }
}
