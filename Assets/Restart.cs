using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Restart : MonoBehaviour
{
    public GameManager gameManager;

    void awake()
    {

        GameManager gameManager = gameObject.GetComponent<GameManager>();
    }


    void TaskOnClick()
    {
        gameManager.reset = true;
    }
}
