using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MethodOverLoadingTest : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        TestPrint(1);
    }

   void TestPrint()
    {
        Debug.Log("method without parameter");
    }

    void TestPrint(int i)
    {
        Debug.Log("method with int parameter");
    }

    void TestPrint(float j)
    {
        Debug.Log("method with float parameter");
    }
}
