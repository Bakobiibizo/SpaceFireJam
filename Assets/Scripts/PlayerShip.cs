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

    public bool[] slots = new bool[] { true, true, true, true };

    public GameObject[] weaponSlotsArray;

    public GameObject[] blasterArray;

    private GameObject newBlaster;

    private string slotNumber;



    void Start()
    {
        //accessing the rigidbody component
        playerShip = GetComponent<Rigidbody2D>();

        weaponSlotsArray[0] = Instantiate(weaponSlotsArray[0], gameObject.transform);
        weaponSlotsArray[1] = Instantiate(weaponSlotsArray[1], gameObject.transform);
        weaponSlotsArray[2] = Instantiate(weaponSlotsArray[2], gameObject.transform);
        weaponSlotsArray[3] = Instantiate(weaponSlotsArray[3], gameObject.transform);
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
            for (int i = 0; i <= 3; ++i)
            {
                if (slots[i] == true)
                {
                    newBlaster = Instantiate(blasterArray[i], weaponSlotsArray[i].transform);
                    slots[i] = false;
                    blasterPieces = 0;

                    slotNumber = "Slot" + i;
                    newBlaster.tag = slotNumber;

                    return;
                }
            }
        }
    }
}
