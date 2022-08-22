using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShip : MonoBehaviour
{

    public List<GameObject> enemyTargets = new List<GameObject>();
    //give the ship 100hp
    public int health = 100;

    //get the death effect animation
    public GameObject deathEffect;

    public GameObject EnemyFire;


    [SerializeField]
    private float enemySpeed = 0.5f;

    private int movementChoice;

    [SerializeField]
    private float fireTimer = 3f;

    private void Awake()
    {
        movementChoice = Random.Range(0, 4);
    }

    public void Update()
    {
          transform.position = Vector2.MoveTowards(transform.position, enemyTargets[movementChoice].transform.position, enemySpeed * Time.deltaTime);
          if(fireTimer>=0){
            fireTimer -= Time.deltaTime;
          }
          if (fireTimer <= 0){
            Instantiate(EnemyFire, transform.position, Quaternion.identity);
            fireTimer += 3;
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

}
