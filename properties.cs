using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;


public class test
{
    properties obj = new properties();
   public void testSpeed()
    {
        Debug.Log(obj.Speed);
        //obj.Speed = 10; cant acess bcoz no setter method availbale
    }
    public void testName()
    {
        obj.name = "Sneha";
        Debug.Log("get" + obj.name);
    }
}
public class properties : MonoBehaviour
{
    // Start is called before the first frame update
    // auto properties
    //public int speed { get; private set; }
    private int _speed;
    public int Speed
    {
        get
        {
            return Speed;
        }
        //set
        //{
        //    Speed = value;
       // }
    }
    private string Name { get; set; }

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
