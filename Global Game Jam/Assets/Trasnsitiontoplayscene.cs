using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Trasnsitiontoplayscene : MonoBehaviour
{
    void Update()
    {
        if (Input.GetButtonDown ("Mouse X")== true)
        {
            Debug.Log("pressed");
            SceneManager.LoadScene("PlayScreen");
        }
    }
}
