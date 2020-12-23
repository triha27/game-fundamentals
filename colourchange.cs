using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class colourchange : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject sphere;
    void Start()
    {
        sphere.GetComponent<Renderer>().material.color = Color.red;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            sphere.GetComponent<Renderer>().material.color = Color.blue;
        }
    }
}
