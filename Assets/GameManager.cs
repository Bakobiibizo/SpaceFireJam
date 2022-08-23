using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public float difficutlyTimer;
    public GameObject[] spawners;
    public bool playerDead = false;
    public GameObject resetButton;
    public int randomNumber;
    public bool reset;
    // Start is called before the first frame update
    void Start()
    {
        difficutlyTimer = 60f;

    }

    // Update is called once per frame
    void Update()
    {
        if (difficutlyTimer > 0)
        {
            difficutlyTimer -= Time.deltaTime;
        }
        else if (difficutlyTimer <= 0)
        {
            randomNumber = Random.Range(0, 4);
            Instantiate(spawners[randomNumber], spawners[randomNumber].transform.position, Quaternion.identity);
            difficutlyTimer = 60f;
        }
        if (reset == true)
        {
            {
                BasicMusic.basicMusicInstance.track++;
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            }
        }
    }
    public void ResetTheGame()
    {
        Instantiate(resetButton, transform.position, Quaternion.identity);
    }
}
