using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    int min = 1;

    int max = 100;

    int guess =50;

    int attempts = 0;

    int maxAttempts = 5;

    // Start is called before the first frame update
    void Start()
    {
        startgame();

        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.DownArrow))
        {
            Lower();
        }
        if(Input.GetKeyUp(KeyCode.UpArrow))
        {
            Higher();
        }
         if(Input.GetKeyDown(KeyCode.Return)) // Enter-toets om het spel te beëindigen
        {
            Finish();
        }
    }

    void startgame()
    {
        guess = Random.Range(min,max + 1);
        Debug.Log("Welcome to number wizard");
        Debug.Log("Pick a number in your head");

        Debug.Log("The highest number you can pick"+max);
        Debug.Log("The lowest number you can pick"+min);
    }
    
    void Nextguess()
    {
        attempts++; // Verhoog de teller
        if (attempts >= maxAttempts)
        {
            Finish();
            return;
        }

        Debug.Log("Is the number higher or lower than"+ guess +"?");
        Debug.Log("Press Up = Higher, Press Down = Lower, Press Enter = Correct");
    }

    void Higher()
    {
        min = guess;
        guess = (min +max)/2;

        Nextguess();
    }

    void Lower()
    {
        max = guess;
        guess = (max +min)/2;

        Nextguess();
    }

    void Finish()
    {
        Debug.Log("Het spel is afgelopen. De uiteindelijke gok was: " + guess);
    }
}

