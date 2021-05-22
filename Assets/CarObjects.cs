using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarObjects : MonoBehaviour
{
    // Start is called before the first frame update
    //create a car instance
    /*  Car myCar1 = new Car();
      Car myCar2 = new Car();
      Car myCar3 = new Car();
    */

 //   public Car myCar;
    public enum Direction { East, West, North, South}
    void Start()
    {
        Direction myDirection;

        myDirection = ReverseDirection(Direction.East);
        Debug.Log("My direction is " + myDirection);
       /* myCar.PrintCarDetails();
        Car myCar1 = new Car(150);
        Car myCar2 = new Car();
        Car myCar3 = new Car("Ferrari", 2000);

        myCar1.carName = "Ferrari";
        myCar1.makeYear = 2010;
        myCar1.maxSpeed = 100.0f;
        myCar1.Drive();
        myCar1.Speed();

        myCar2.carName = "Suzuki";
        myCar2.makeYear = 2015;
        myCar2.maxSpeed = 150.0f;
        myCar2.Drive();
        myCar2.Speed();

        myCar3.carName = "Ford";
        myCar3.makeYear = 2020;
        myCar3.maxSpeed = 200.0f;
        myCar3.Drive();
        myCar3.Speed();*/
    }


    public Direction ReverseDirection(Direction myDirection)
    {
        Direction dir;

        dir = Direction.East;

        if(myDirection == Direction.East)
        {   dir = Direction.North;    }
        return dir;
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
