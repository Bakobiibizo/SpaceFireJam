using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public float numberDifficulty = 2f;

    public float interval = 0;

    public float timeDifficulty = 5f;

    public GameObject enemyShip;


    void Update()
    {
        if (interval > 0)
        {
            interval -= Time.deltaTime;
        }
        if (interval <= 0)
        {
            for (int i = 0; i < numberDifficulty; ++i)
            {
                Instantiate(enemyShip, transform.position, Quaternion.identity);
            }
            interval = timeDifficulty;

        }

    }
}
