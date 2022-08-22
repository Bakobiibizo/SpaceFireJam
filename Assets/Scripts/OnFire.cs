using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnFire : MonoBehaviour
{
    public GameObject weaponFire;
    public GameObject weaponSpawn;
    public float wait = 1f;
    private bool timer = false;
    private float waitTime;


    void Start()
    {
        waitTime = wait;
    }
    void Update()
    {
        if (timer == true)
        {
            if (waitTime > 0)
            {
                waitTime -= Time.deltaTime;
            }
            if (waitTime <= 0)
            {
                timer = false;
                waitTime = wait;
            }
        }

        //checking if the fire button has been fired
        if (Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0))
        {
            if (timer == false)
            {
                //create the weapon fire animation
                Instantiate(weaponFire, weaponSpawn.transform.position, Quaternion.identity);
                timer = true;
            }
        }
    }
}