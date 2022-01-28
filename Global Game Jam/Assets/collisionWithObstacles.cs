using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collisionWithObstacles : MonoBehaviour
{
    public GameObject blueFish;
    public GameObject redFish;
    public GameObject lm;
    LevelManager levelManager;
    // Start is called before the first frame update
    void Start()
    {
 
        levelManager = lm.GetComponent<LevelManager>();
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.layer == 7)
        {
            if(this.gameObject == redFish)
            {
                levelManager.orangeAmmount -= 1;
                print("red");
            }
            else if(this.gameObject == blueFish)
            {
                print("blue");
                levelManager.blueAmmount -= 1;
            }
        }
    }
}
