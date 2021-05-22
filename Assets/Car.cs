using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//this is empty car class
[System.Serializable]
public class Car
{
    //attributes or properties
    public string carName;
    public int makeYear;
    public float maxSpeed;
    public const float PI = 3.14f;

    //constructor

    public Car()
    {
        Debug.Log("Car Default Constructor Called");
    }
 
    public Car(float maximumSpeed)
    {
        maxSpeed = maximumSpeed;
        Debug.Log("Second Constructor Called");
        Debug.Log("The max speed of the car: " + maxSpeed);
    } 

    public Car(string name, int year)
    {
        carName = name;
        makeYear = year;
        Debug.Log("Third Constructor Called");
        Debug.Log("My car name is " + carName);
        Debug.Log("My car Manufacturing year is " + makeYear);

    }
    //behaviours or functions
    public void Drive()
    {
        Debug.Log("My car name is "+ carName);
    }
    
   public void ApplyBrake()
    {
        Debug.Log("This is to apply car brake");
    }

    public void PrintCarDetails()
    {
        Debug.Log("My car name is " + carName);
        Debug.Log("My car Manufacturing year is " + makeYear);
        Debug.Log("The Car Maxspeed is " + maxSpeed);

    }
}
