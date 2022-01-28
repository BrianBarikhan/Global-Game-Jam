using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fishesExpandAndContract : MonoBehaviour
{
    public float maxRadius;
    public float minRadius;
    public float radiusChangeSpeed;
    public GameObject thisFish;
    public GameObject otherFish;
    public GameObject parentObjectFish;
    public KeyCode contractingButton;
    public KeyCode expandingButton;
    public float rotationSpeed;
    public float temporaryRadius;
    Vector3 temporaryRotation;
    
    // Start is called before the first frame update
    void Start()
    {
        temporaryRadius = Mathf.Sqrt(Mathf.Pow(thisFish.transform.position.x - otherFish.transform.position.x, 2) + Mathf.Pow(thisFish.transform.position.y - otherFish.transform.position.y ,2));
        temporaryRotation = transform.rotation.eulerAngles;
    }

    // Update is called once per frame
    void Update()
    {
        
        if(temporaryRadius > minRadius)
        {
            if (Input.GetKey(contractingButton))
            {
                thisFish.transform.position = Vector2.MoveTowards(thisFish.transform.position, parentObjectFish.transform.position, radiusChangeSpeed);
                otherFish.transform.position = Vector2.MoveTowards(otherFish.transform.position, parentObjectFish.transform.position, radiusChangeSpeed);
                temporaryRadius = Mathf.Sqrt(Mathf.Pow(thisFish.transform.position.x - otherFish.transform.position.x, 2) + Mathf.Pow(thisFish.transform.position.y - otherFish.transform.position.y, 2));

            }
        }

        if(temporaryRadius < maxRadius)
        {
            if (Input.GetKey(expandingButton))
            {
                thisFish.transform.position = Vector2.MoveTowards(thisFish.transform.position, parentObjectFish.transform.position, -radiusChangeSpeed);
                otherFish.transform.position = Vector2.MoveTowards(otherFish.transform.position, parentObjectFish.transform.position, -radiusChangeSpeed);
                temporaryRadius = Mathf.Sqrt(Mathf.Pow(thisFish.transform.position.x - otherFish.transform.position.x, 2) + Mathf.Pow(thisFish.transform.position.y - otherFish.transform.position.y, 2));


            }
        }
        temporaryRotation.z += rotationSpeed;
        parentObjectFish.transform.rotation = Quaternion.Euler(temporaryRotation);
        
    }
}
