using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class EnemyFire : MonoBehaviour
{
    public float enemyProjectileSpeed = 1f;
    public int damage = 20;
    public float enemyLifespan = 1.5f;
    public GameObject enemyHit;

    void Start()
    {
        Destroy(gameObject, enemyLifespan);
    }

    void Update()
    {
        transform.position += new Vector3(0,-1,0)*Time.deltaTime*enemyProjectileSpeed;
    }


    void OnTriggerEnter2D(Collider2D hitInfo)
    {

        PlayerShip player = hitInfo.GetComponent<PlayerShip>();

        if (hitInfo.tag == "Player")
        {
            player.TakeDamage(damage);
            Destroy(gameObject);
            Instantiate(enemyHit, transform.position, Quaternion.identity);
        }
    }
}