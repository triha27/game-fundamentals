using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoolManager : MonoBehaviour
{
    [SerializeField]
    private GameObject bulletprefab;
    [SerializeField]
    private List<GameObject> bullets;
    [SerializeField]
    private GameObject bulletPool;
    private static PoolManager _instance;
    public static PoolManager Instance
    {
        get
        {
            if(_instance == null)
            {
                Debug.LogError("no intsnce of Pool Manager found");
            }
            return _instance;
        }
    }
    private void Awake()
    {
        _instance = this;
       bullets = BulletsGenerate(14);
    }
   
    private List<GameObject> BulletsGenerate(int no)
    {
       
        for(int i = 0; i < no; i++)
        {
            GameObject bull = Instantiate(bulletprefab);
            bull.transform.parent = bulletPool.transform;
            bull.SetActive(false);
            bullets.Add(bull);
        }
        return bullets;

    }
    public GameObject RequestBullet()
    {
      
        foreach(var bull in bullets)
        {
            if(!bull.activeSelf)
            {
                bull.SetActive(true);
                return bull; 
            }
        }
            bullets = BulletsGenerate(5);
            return RequestBullet();
    }

}
