using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Balance : MonoBehaviour
{
    public Sprite newSprite1, newSprite2, newSprite3;
   GameObject Blue ;
    GameObject Orange;
    private AmmountCheck AC1, AC2;
    SpriteRenderer renderer;
    void Start()
    {
        Blue = GameObject.Find("BlueCup");
       Orange = GameObject.Find("OrangeCup");
        AC1 = Blue.GetComponent<AmmountCheck>();
       AC2 = Orange.GetComponent<AmmountCheck>();
       renderer = gameObject.GetComponent<SpriteRenderer>();
    }

    
    void Update()
    {
        if (AC1.AmmountCollected==AC2.AmmountCollected)
        {
            renderer.sprite = newSprite1;
        }
        else if (AC1.AmmountCollected > AC2.AmmountCollected)
        {
            renderer.sprite = newSprite2;
        }
        else if (AC1.AmmountCollected < AC2.AmmountCollected)
        {
            renderer.sprite = newSprite3;
        }

    }
}
