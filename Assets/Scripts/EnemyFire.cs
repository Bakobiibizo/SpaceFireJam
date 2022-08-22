using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class EnemyFire : MonoBehaviour
{
    public float enemyProjectileSpeed = 1f;
    public int damage = 20;
    public float enemyLifespan = 1.5f;
    public GameObject enemyHit;
    public string[] hitable;

    void Start()
    {
        Destroy(gameObject, enemyLifespan);
    }

    void Update()
    {
        transform.position += new Vector3(0, -1, 0) * Time.deltaTime * enemyProjectileSpeed;
    }


    void OnTriggerEnter2D(Collider2D hitInfo)
    {

        OnHit onHit = hitInfo.GetComponent<OnHit>();
        for (int i = 0; i <= 5; i++)
        {
            if (hitInfo.tag == hitable[i])
            {
                onHit.TakeDamage(damage, i);
                Destroy(gameObject);
                Instantiate(enemyHit, transform.position, Quaternion.identity);

            }
        }
    }
}
