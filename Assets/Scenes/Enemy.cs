using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//this is base class
public class Enemy : MonoBehaviour
{
   
    protected void Attack()
    {
        Debug.Log("Enemy Attack");
        GetComponent<Renderer>().material.color = Color.red;
    }       
}
