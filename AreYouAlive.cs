using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AreYouAlive : MonoBehaviour
{
    // Start is called before the first frame update
    public int health;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown (KeyCode.Space))
        {
            if(health>0)
            {
                Damage();
            }
        }
    }
    private void Damage()
    {
        int dam = Random.Range(0, 100);
        health = health - dam;
    }
}
