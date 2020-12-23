using System.Collections;
using System.Collections.Generic;
using UnityEditorInternal;
using UnityEngine;


public class SpawnManager : MonoBehaviour
{
    // Start is called before the first frame update
    private static SpawnManager _instance;
    public static SpawnManager Instance
    {
        get
        {
            if (_instance == null)
                Debug.LogError("_instance is empty");
            return _instance;
        }
    }
    public void StartSpawning()
    {
        Debug.Log("spawnning");
    }

    private void Awake()
    {
        _instance = this;
    }



}






