using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPlayer : MonoBehaviour
{
    public GameObject thisPlayerShip;

    void Start()
    {
       thisPlayerShip  = Instantiate(thisPlayerShip);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
