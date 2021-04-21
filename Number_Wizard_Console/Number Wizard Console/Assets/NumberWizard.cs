using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour
{
    int max = 1000, min = 1, guess, counter = 1;
    // Start is called before the first frame update
    void Start()
    {
        StartGame();
    }

    void StartGame()
    {
        guess = (max + min) / 2;
        max += 1;
        Debug.Log("Top of the morning to ya mate, Welcome to Number Wizard");
        Debug.Log($"I'll be trying to guess your number of choice where the number is between {min} and {max - 1}, inclusive");
        Debug.Log("My current Guess is: " + guess);
        Debug.Log("Tell me if your number is higher or lower than " + guess);
        Debug.Log("Pressing UP KEY means Higher, Pressing DOWN KEY means Lower, and Pressing ENTER means Correct");
    }

    void NextGuess()
    {
        guess = (max + min) / 2;
        Debug.Log("Is it higher or lower than... " + guess);
        counter += 1;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            min = guess;
            NextGuess();


        } else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            max = guess;
            NextGuess();
        } else if (Input.GetKeyDown(KeyCode.Return))
        {
            if (counter == 1)
            {
                Debug.Log($"Your number is {guess} and I only guessed once");
            } else
            {
                Debug.Log($"Your number is {guess} and I only guessed {counter} times");
            }
            max = 1000;
            min = 1;
            counter = 1;
            StartGame();
        }
    }
}
