using UnityEngine;
using System.Collections;
using System.IO;

public class JsonFileSaveManager : MonoBehaviour 
{
    public Dragon oldDragon;
    public Dragon newDragon;
    string fileDataPath=string.Empty;

	void Start () 
    {
        fileDataPath = Application.streamingAssetsPath+"myFirstJSON.json"; 

        putToFile();
        getFromFile();

	}

    void putToFile()
    {
        //переводим в json
        string bufString = JsonUtility.ToJson(oldDragon);  
        File.WriteAllText(fileDataPath,bufString);
        Debug.Log("Old Dragon :" + oldDragon.dragonData.Name.ToString() + oldDragon.dragonData.Age.ToString() + oldDragon.dragonData.Level.ToString());
    }

    void getFromFile()
    {
        if (File.Exists(fileDataPath))
        {
            string bufString = File.ReadAllText(fileDataPath);

            JsonUtility.FromJsonOverwrite(bufString, newDragon); 
         
            Debug.Log("New Dragon :" + newDragon.dragonData.Name.ToString() + newDragon.dragonData.Age.ToString() + newDragon.dragonData.Level.ToString());
        }
        else
            Debug.Log("File dont exist");
    }
}
