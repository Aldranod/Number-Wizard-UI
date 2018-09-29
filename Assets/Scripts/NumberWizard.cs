using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro; // get into text mesh pro
using UnityEngine.UI;

public class NumberWizard : MonoBehaviour
{
    [SerializeField] int max;
    [SerializeField] int min;
    [SerializeField] TextMeshProUGUI guessText;
    int guess;

    public GameObject buttonH;
    public GameObject buttonL;

    // Use this for initialization
    void Start ()
    {
        StartGame();
    }

    void StartGame()
    {
        NextGuess();
    }

    public void OnPressHigher()
    {
        if(min >= 1000)
        {
            DisableButtons();
        }
        else
        {
            min = guess + 1;
        }
        NextGuess();
    }
    public void OnPressLower()
    {
        if(max <= 1)
        {
            DisableButtons();
        }
        else
        {
            max = guess - 1;
        }
        NextGuess();
    }

    void NextGuess()
    {
        guess = Random.Range(min, max);
        guessText.text = guess.ToString();
    }

    void DisableButtons()
    {
        //if (max >= 1000 && min >= 1000)
        //{
            Button HisTicked = buttonH.GetComponent<Button>();
            HisTicked.interactable = false;
            Button LisTicked = buttonL.GetComponent<Button>();
            LisTicked.interactable = false;
        //    guess = 1000;
        //    guessText.text = guess.ToString();
        //}
        //else if(min <= 1 && max <= 1)
        //{
        //    Button HisTicked = buttonH.GetComponent<Button>();
        //    HisTicked.interactable = false;
        //    Button LisTicked = buttonL.GetComponent<Button>();
        //    LisTicked.interactable = false;
        //    guess = 1;
        //    guessText.text = guess.ToString();
        //}

    }
}
