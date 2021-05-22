using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class staticTest : MonoBehaviour
{
    // Start is called before the first frame update
    static int score = 0;

    static void IncrementScore()
    {
        Debug.Log("Updated Score is  " + ++score);
    }
    
    void Start()
    {
        staticTest myTest = new staticTest();
        IncrementScore();
        
    }

    // Update is called once per frame
    void Update()
    {
       // IncrementScore();
    }
}
