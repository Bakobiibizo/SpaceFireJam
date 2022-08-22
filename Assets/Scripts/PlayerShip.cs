using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShip : MonoBehaviour
{

    public GameObject weaponFire;
    //declaring a transform for the position that it will spawn in
    public Transform weaponSpawnTransform;
    // declaring the ships rigidbody
    private Rigidbody2D playerShip;
    // declaring the speed of the ship
    public float playerSpeed = 3f;

    public int health = 100;

    //get the death effect animation
    public GameObject deathEffect;

    public float blasterPieces = 0f;

    public float lazerPieces = 0f;

    public float missilePieces = 0f;

    public GameObject weaponSlot;

    public GameObject blaster;


    void Start()
    {
        //accessing the rigidbody component
        playerShip = GetComponent<Rigidbody2D>();
        weaponSlot = Instantiate(weaponSlot, gameObject.transform);


    }

    void Update()
    {
        //getting the playing input for vertical and horizontal movement.
        Vector3 playerInput = new Vector3(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"), 0);
        //moving the player based on player input.
        transform.position = transform.position + playerInput.normalized * playerSpeed * Time.deltaTime;

        //checking if the fire button has been fired
        if (Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0))
        {
            //create the weapon fire animation
            Instantiate(weaponFire, weaponSpawnTransform.position, weaponSpawnTransform.rotation);
        }
    }

    public void TakeDamage(int damage)
    {
        //ship takes damage
        health -= damage;
        //if at or below 0
        if (health <= 0)
        {
            //run the die function
            Die();
        }
    }

        private void Die()
    {
        {
            //create the death animation
            Instantiate(deathEffect, transform.position, Quaternion.identity);
            //destroy the ship
            Destroy(gameObject);

        }
    }

        public void WeaponUpgrades(string weaponType)
        {
            if(weaponType == "blaster")
            {
                blasterPieces ++;
            }
            if (weaponType == "lazer")
            {
                lazerPieces ++;
            }
            if (weaponType == "missile")
            {
                missilePieces ++;
            }
            if (blasterPieces >=2)
            {
                Instantiate(blaster, weaponSlot.transform);

            }
        }

}
