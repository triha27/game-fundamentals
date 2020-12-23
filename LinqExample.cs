using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

[System.Serializable]
public class ItemTwo
{
    public string name;
    public int ItemID;
    public int buff;
}
public class LinqExample : MonoBehaviour
{
    // Start is called before the first frame update
    public List<ItemTwo> items;
    void Start()
    {
       var check =  items.Any(it => it.ItemID == 3 );
        var above20 = items.Where(it => it.buff > 20);
        foreach(var a in above20)
        {
            Debug.Log(a.buff);
        }
       double result = items.Average(q => q.buff);
        Debug.Log(result);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
