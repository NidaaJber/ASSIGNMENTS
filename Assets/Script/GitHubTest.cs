using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GitHubTest : MonoBehaviour
{
   
    void Start()
    {
        int randomValue = Random.Range(1, 21); 
        int number = 1;

       
        while (number <= 15)
        {
            if (number == 5)
            {
                number++; 
                continue;
            }    

            Debug.Log(number);

            if (number == 15)
            {
                break; 
            }

            number++; 
        }
    }

    void Update()
    {
        
    }
}

