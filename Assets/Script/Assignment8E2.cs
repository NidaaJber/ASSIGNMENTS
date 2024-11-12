using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Assignment8E2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
         string[] words = { "Cat", "Dog", "Car", "Pizza", "Hat", "Fish", "Tree", "Monkey", "Ball", "Bird" };
         
        System.Random random = new System.Random();
      
        int wordCount = 0;
        string sentence = "";

         while (wordCount < 7)
        {
            int index = random.Next(words.Length); 
            sentence += words[index] + " ";
            wordCount++;
        }

       Debug.Log("Funny sentence: " + sentence.Trim());

        
        
    }


    

    // Update is called once per frame
    void Update()
    {
        
    }
}

