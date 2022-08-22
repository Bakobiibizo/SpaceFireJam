using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponFire : MonoBehaviour
{
    public float speed = 2f;
    public int damage = 40;
    public float lifespan = 1.5f;
    public GameObject weaponHit;

    private void Start()
    {
        Destroy(gameObject, lifespan);
    }

    private void Update()
    {
        transform.position += new Vector3(0, 1, 0) * Time.deltaTime * speed;
    }

    void OnTriggerEnter2D(Collider2D hitInfo)
    {
        EnemyShip enemy = hitInfo.GetComponent<EnemyShip>();

        if (hitInfo.tag == "Enemy")
        {
            enemy.TakeDamage(damage);
            Destroy(gameObject);
            Instantiate(weaponHit, transform.position, Quaternion.identity);
        }
    }
}