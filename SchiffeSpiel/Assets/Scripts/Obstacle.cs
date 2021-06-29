using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Obstacle : MonoBehaviour
{
    private GameObject player;
    private GameObject hit;
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        hit = GameObject.FindGameObjectWithTag("Obstacle");
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Player")
        {
            Destroy(player.gameObject);
            SceneManager.LoadScene("GameOver");
        }
        else if(collision.tag == "Bullet")
        {
            Destroy(hit.gameObject);
        }
    }
}
