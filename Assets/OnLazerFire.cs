using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnLazerFire : MonoBehaviour
{
    public float timer;
    public int damage= 50;

    void Start()
    {
        timer = 1f;

    }

    void Update()
    {
        if (timer > 0){
            timer -= Time.deltaTime;
            Debug.Log(timer);
        if (timer<= 0){
            Shoot();
        }
        }
    }
    void Shoot(){
        RaycastHit2D hit = Physics2D.Raycast(transform.position, transform.TransformDirection(Vector2.up), 10f);
        Debug.Log(hit.collider.name);
        if (hit) {
            EnemyShip enemyShip = hit.transform.GetComponent<EnemyShip>();
            enemyShip.TakeDamage(damage);
        }
    }
}
