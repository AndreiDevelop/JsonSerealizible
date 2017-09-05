using UnityEngine;
using System.Collections;

public class DragonsManager : MonoBehaviour 
{
    private static DragonsManager _instance;

    void Awake()
    {
        if (_instance == null)
            _instance = this;
        else if (_instance != this)
            Destroy(gameObject);

        DontDestroyOnLoad(gameObject);
    }
}
