using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLives : MonoBehaviour
{
   int playerLives = 3;

    void Start()
    {
        while (playerLives > 0)
        {
            if (playerLives == 3)
            {
                Debug.Log("Many lives");  
            }
            else if (playerLives == 1)
            {
                Debug.Log("The last life!");  
            }

           
            playerLives--;

          
            if (playerLives == 0)
            {
                Debug.Log("Game Over!");  
            }
        }
    }
}




