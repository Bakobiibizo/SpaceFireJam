using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OnHit : MonoBehaviour
{

    public float health = 100f;
    public GameObject deathEffect;
    private PlayerShip boolToSet;
    public GameObject GameManager;

    private int slotNumber;

    public void TakeDamage(int damage, int i)
    {
        //ship takes damage
        health -= damage;
        //if at or below 0
        if (health <= 0)
        {
            //run the die function
            Die(i);
        }
    }
    private void Die(int i)
    {

        if ((i - 2) >= 0)
        {
            GameObject g = GameObject.FindGameObjectWithTag("Player");
            boolToSet = g.GetComponent<PlayerShip>();
            boolToSet.slots[i - 2] = true;
        }
        if (i == 1)
        {
            GameManager gameManager = GameManager.GetComponent<GameManager>();
            gameManager.ResetTheGame();
            gameManager.playerDead = true;
        }
        //create the death animation
        Instantiate(deathEffect, transform.position, Quaternion.identity);


        //destroy the ship
        Destroy(gameObject);

    }
}
