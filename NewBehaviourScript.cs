using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Security.Cryptography;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    private float speed;
    [SerializeField]
    private float HorizontalMovement;
    [SerializeField]
    private float VerticalMovement;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.S))
        {
            speed = speed + 5;
        }
        if (Input.GetKeyDown(KeyCode.X))
        {
            if (speed <= 0)
            {
                speed = 0;
            }
            else speed = speed - 1;
        }
        if (speed == 0)
        {
            Debug.Log("Speed up");
        }
        if(speed < 20)
        {
            Debug.Log("Slow down");
        }
       
       HorizontalMovement = Input.GetAxis ("Horizontal");
        VerticalMovement = Input.GetAxis("Vertical");
        if(VerticalMovement == 0)
        transform.Translate(new Vector3 (HorizontalMovement,0,0)*speed * Time.deltaTime);
        if (HorizontalMovement == 0)
           transform.Translate(new Vector3(0, VerticalMovement, 0) * speed * Time.deltaTime);
        
    }
}
