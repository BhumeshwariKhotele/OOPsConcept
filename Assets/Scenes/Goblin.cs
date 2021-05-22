using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//derived class
public class Goblin : MonoBehaviour
{
    private void Start()
    {
        Goblin myGoblin = new Goblin();
        myGoblin.Attack();

        Goblin redGoblin = new RedGoblin();
        redGoblin.Attack();

        Goblin whiteGoblin = new WhiteGoblin();
        whiteGoblin.Attack();

    }
   
    public virtual void Attack() //use virtual is we are using override
    {
        Debug.Log("G0blin attack");
    }
}


public class RedGoblin : Goblin
{
    public override void Attack()
    {
        Debug.Log("RedGoblin attack");
    }
}


public class WhiteGoblin : Goblin
{
    public override void Attack()
    {
        Debug.Log("WhiteGoblin attack");
    }
}