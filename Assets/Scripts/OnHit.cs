using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnHit : MonoBehaviour
{

    public float health = 100f;
    public GameObject deathEffect;



    public int slotNumber;

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
            //create the death animation
            Instantiate(deathEffect, transform.position, Quaternion.identity);

            //destroy the ship
            Destroy(gameObject);
    }
}
