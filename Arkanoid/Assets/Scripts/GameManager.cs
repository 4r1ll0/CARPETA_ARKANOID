using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public int lives = 3;


    public void LosseHealht()
    {
        lives--;

        if (lives <= 0)
        {
            SceneManager.LoadScene("Gameover");
        }
        else
        {
            ResetLevel();
        }

    }

    public void ResetLevel()
    {
       FindObjectOfType<Pelota>().ResetPelota();
       FindObjectOfType<Jugador>().ResetJugador();
    }


}

   

