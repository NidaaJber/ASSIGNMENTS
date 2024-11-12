using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GitHubTest : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
         Random.Range(1,21);
            int number = 1;

        while (true)
        {
          

            if (number == 5)
            {
                continue; 
            }    

           Debug.Log (number);

            if (number == 15)
            {
                break; 
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
