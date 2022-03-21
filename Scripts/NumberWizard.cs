using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class NumberWizard : MonoBehaviour
{

    [SerializeField] int max = 1000;
    [SerializeField] int min = 1;
    [SerializeField] TextMeshProUGUI guesstext;
    int guess;

    // Start is called before the first frame update
    void Start() {
        StartGame();
    }

    void StartGame() {
        //guess = (max + min) / 2;
        //guesstext.text = guess.ToString();
        NextGuess();
        max += 1;
    }


    public void OnPressHigher() {
        min = guess + 1;
        NextGuess();
    }

    public void OnPressLower() {
        max = guess - 1;
        NextGuess();
    }


    void NextGuess() {
        //guess = (max + min) / 2;
        guess = Random.Range(min, max + 1);
        guesstext.text = guess.ToString();
    }
}
