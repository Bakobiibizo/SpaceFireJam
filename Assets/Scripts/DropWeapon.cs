using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DropWeapon : MonoBehaviour
{


    [SerializeField]
    private float speed = 2f;

    public string weaponType;
    public AudioSource audioSource;

    private void Awake()
    {
        audioSource = gameObject.GetComponent<AudioSource>();
    }

    void Update()
    {
        transform.position += new Vector3(0.0f, -1.0f, 0.0f) * speed * Time.deltaTime;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        PlayerShip player = collision.GetComponent<PlayerShip>();
        if (collision.tag == "Player")
        {
            {


                Destroy(gameObject);

                player.WeaponUpgrades(weaponType);
                audioSource.Play();

            }
        }

    }
}
