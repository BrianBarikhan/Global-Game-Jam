using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    
    GameObject Blue;
    GameObject Orange;
    private AmmountCheck AC1, AC2;
    public int BlueAmmount, OrangeAmmount;
    void Start()
    {
        Blue = GameObject.Find("BlueCup");
        Orange = GameObject.Find("OrangeCup");
        AC1 = Blue.GetComponent<AmmountCheck>();
        AC2 = Orange.GetComponent<AmmountCheck>();
        BlueAmmount = AC1.AmmountCollected;
        OrangeAmmount = AC2.AmmountCollected;
    }
   
}
