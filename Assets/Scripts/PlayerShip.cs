using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShip : MonoBehaviour
{

    private Rigidbody2D playerShip;
    // declaring the speed of the ship
    public float playerSpeed = 3f;

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
    }

    public void WeaponUpgrades(string weaponType)
    {
        if (weaponType == "blaster")
        {
            blasterPieces++;
        }
        if (weaponType == "lazer")
        {
            lazerPieces++;
        }
        if (weaponType == "missile")
        {
            missilePieces++;
        }
        if (blasterPieces >= 2)
        {
            Instantiate(blaster, weaponSlot.transform);

        }
    }

}