using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class slowCheck : MonoBehaviour
{
    // Start is called before the first frame update
    public int speed;
    private int _maxSpeed;
    void Start()
    {
        _maxSpeed = Random.Range(60, 120);
        StartCoroutine(maxSpeed());
    }

    // Update is called once per frame
    void Update()
    {
       // StartCoroutine(countCheck());
    }
    
    IEnumerator maxSpeed()
    {
        //for (int i = 0; i<100; i++)
        //{
            //check++;
           // yield return new WaitForSeconds(1.0F);
        //}
        while(true)
        {
            speed += 5;
            if(speed >= _maxSpeed)
            {
                break;
            }
            yield return new WaitForSeconds(1.0F);
        }
    }
}
