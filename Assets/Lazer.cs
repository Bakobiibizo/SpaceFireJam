using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lazer : MonoBehaviour
{

    public GameObject lazerFire;
    public GameObject lazerSpawn;
    public float damage = 80f;
    public float wait = 5f;
    private bool timer = false;
    private float waitTime;

    // Start is called before the first frame update
    void Start()
    {
        waitTime = wait;

    }

    // Update is called once per frame
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
        if (Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0))
        {
            if (timer == false)
            {
                Instantiate(lazerFire, lazerSpawn.transform.position, Quaternion.identity);
                Shoot();
                timer = true;
            }
        }

    }
    void Shoot()
    {
        RaycastHit hit;
        if (Physics.Raycast(lazerSpawn.transform.position, lazerSpawn.transform.up, out hit))
        {
            Debug.Log(hit.transform.name);
        }
    }
}
