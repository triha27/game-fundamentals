using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Item
{
    public string name;
    public int itemId;
    public string description;
}
public class arrayIterate : MonoBehaviour
{
    // Start is called before the first frame update
    public Item[] myItem;
    void Start()
    {
        foreach (var n in myItem)
        {
            Debug.Log(n.itemId + " " + n.name);
        }
    }

    // Update is called once per frame
    void Update()
    {
        int randomDesc = Random.Range(0, myItem.Length);
        Debug.Log(myItem[randomDesc].description);
    }
}
