using System.Collections;
using System.Collections.Generic;
//using System.Security.Policy;
using UnityEngine;

public class ReturnArray : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject[] players;

    void Start()
    {
        players = GetAllPlayers();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    private GameObject[] GetAllPlayers()
    {
        GameObject[] toReturn = GameObject.FindGameObjectsWithTag("Player");
        foreach (var g in toReturn)
        {
            g.GetComponent<MeshRenderer>().material.color = new Color(Random.value, Random.value, Random.value);
        }
        return toReturn;
    }
}
