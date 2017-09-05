using UnityEngine;

[System.Serializable]
public class Dragon : MonoBehaviour 
{
    public DragonData dragonData;
    public string pathToDragonData = "ScriptableObject/DragonData";

    void Awake()
    {
        dragonData = Resources.Load<DragonData>(pathToDragonData);
    }

    void Attack(){}

    void Fly(){}
}
