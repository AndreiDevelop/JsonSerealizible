using UnityEngine;

[System.Serializable]
public class DragonData : ScriptableObject
{
    [SerializeField]
    private string _name;
    public string Name
    {
        get
        {
            return _name;
        }
        set
        {
            _name = (string.IsNullOrEmpty(value)) ? "Bill Dragon" : value;
        }
    }

    [SerializeField]
    private uint _age;
    public uint Age
    {
        get
        {
            return _age;
        }
        set
        {
            _age = (value == 0) ? 100 : value;
        }
    }

    [SerializeField]
    private uint _level;
    public uint Level
    {
        get
        {
            return _level;
        }
        set
        {
            _level = (value == 0) ? 1 : value; 
        }
    }
}
