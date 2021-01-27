using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour
{
    int max;
    int min;
    int guess;

    // Start is called before the first frame update
    void Start()
    {
        StartGame();
    }

    void StartGame()
    {
        max = 1000;
        min = 1;
        guess = 500;

        Debug.Log("Welcome to Number Wizard");
        Debug.Log("Choose a number, don't reveal what it is...");
        Debug.Log("You may choose any number as high as " + max);
        Debug.Log("Or any number as low as " + min);
        Debug.Log("Is your number higher or lower than " + guess + "?");
        Debug.Log("Push Up = Higher, Push Down = Lower, Push Enter = Correct");
        max = max + 1;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            min = guess;
            NextGuess();
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        { 
            max = guess;
            NextGuess();
        }
        else if (Input.GetKeyDown(KeyCode.Return))
        {
            Debug.Log("Your number is "+guess);
            Debug.Log("Good job.");
            StartGame();
        }
    }
    void NextGuess()
    {
            guess = (max + min) / 2;
            Debug.Log("Is your number higher or lower than " + guess + "?");
        }
}
