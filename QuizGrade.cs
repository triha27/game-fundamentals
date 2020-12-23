using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using JetBrains.Annotations;

public class QuizGrade : MonoBehaviour
{
    // Start is called before the first frame update
    public int[] scores = new int[10];
    void Start()
    {
        var filteredScore = scores.Where(n => n > 69).OrderByDescending(q => q).Reverse();
        foreach(int a in filteredScore)
        {
            Debug.Log(a);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
