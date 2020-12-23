using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour
{
    // Start is called before the first frame update
   private void OnEnable()
    {
        Invoke("Hide", 2f);
    }

    private void Hide()
    {
        this.gameObject.SetActive(false);
    }
    // Update is called once per frame
    
}
