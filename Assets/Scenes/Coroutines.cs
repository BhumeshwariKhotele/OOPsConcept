using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coroutines : MonoBehaviour
{
    private void Awake()
    {

    }

    void Start()
    {
        StartCoroutine("Colourtest");
    }
    IEnumerator Colourtest()
    {
        print("Start of coroutines");
        yield return new WaitForSeconds(2.0f);
        GetComponent<Renderer>().material.color = Color.red;

        yield return new WaitForSeconds(2.0f);
        GetComponent<Renderer>().material.color = Color.green;

        yield return new WaitForSeconds(2.0f);
        GetComponent<Renderer>().material.color = Color.blue;

        yield return new WaitForSeconds(2.0f);
        GetComponent<Renderer>().material.color = Color.yellow;

        yield return null;//wait for end of frame
        print("End of coroutine");
    }

    void ColorsTest()
    {
        print("Start of normal function");
        GetComponent<Renderer>().material.color = Color.red;
        GetComponent<Renderer>().material.color = Color.green;
        print("End of normal function");
    }
    
}
