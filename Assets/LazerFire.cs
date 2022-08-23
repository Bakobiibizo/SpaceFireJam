using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LazerFire : MonoBehaviour
{
    /*declare variables, lazer fire and spawn are for instantiating the animation
    damage is for on hit, wait, waitTime and timer is to time the lazer fire frequency and
    raySpeed is for tuning the speed of the ray cast
    */
    public GameObject lazerFire;
    public GameObject lazerSpawn;
    public int damage = 20;
    public float wait = 5f;
    private bool timer = false;
    private float waitTime;


    // Start is called before the first frame update
    void Start()
    {
        // set waitTimer
        waitTime = wait;

    }

    // Update is called once per frame
    void Update()
    {
        //run the timer
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
        //checking for mouse input
        if (Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0))
        {
            //if the lazer is not on cool down
            if (timer == false)
            {
                //spawn the animation and fire the ray cast
                Instantiate(lazerFire, lazerSpawn.transform);


                timer = true;
            }
        }

    }

}