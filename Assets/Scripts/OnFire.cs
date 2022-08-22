using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnFire : MonoBehaviour
{
    public GameObject weaponFire;
    public GameObject weaponSpawn;

    void Update()
    {
        //checking if the fire button has been fired
        if (Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0))
        {
            //create the weapon fire animation
            Instantiate(weaponFire, weaponSpawn.transform.position, Quaternion.identity);
        }
    }
}