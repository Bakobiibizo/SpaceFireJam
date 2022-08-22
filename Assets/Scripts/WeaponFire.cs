using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponFire : MonoBehaviour
{
    public float speed = 2f;
    public int damage = 40;
    public float lifespan = 1.5f;
    public GameObject weaponHit;
    public float wait = 1f;
    public bool timer = false;
    public float waitTime;

    private void Start()
    {
        waitTime = wait;
        Destroy(gameObject, lifespan);
    }

    private void Update()
    {
        transform.position += new Vector3(0, 1, 0) * Time.deltaTime * speed;
        if (timer == true)
        {
            if (waitTime > 0)
            {
                wait -= Time.deltaTime;
            }
            if (wait <= 0)
            {
                timer = false;
                waitTime = wait;
            }
        }
    }

    void OnTriggerEnter2D(Collider2D hitInfo)
    {
        EnemyShip enemy = hitInfo.GetComponent<EnemyShip>();

        if (hitInfo.tag == "Enemy")
        {
            if (timer == false)
            {
                enemy.TakeDamage(damage);
                Destroy(gameObject);
                Instantiate(weaponHit, transform.position, Quaternion.identity);
                timer = true;
            }
        }
    }
}