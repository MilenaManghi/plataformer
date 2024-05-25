using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Controller_Player_Floating : Controller_Player
{
    public override void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Floor"))
        {
            onFloor = true;
        }
        if (collision.gameObject.CompareTag("Meta"))
        {
            Time.timeScale = 1;
            GameManager.nivel = +1;
            SceneManager.LoadScene(GameManager.nivel);
        }
        //This makes the player invulnerable to water.
    }
}
