using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using PurpleTalk;
using PurpleTalk.UI;


public class NamespaceTest : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
       PurpleGames.PurplePrint();
        MyUI.DoUI();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
