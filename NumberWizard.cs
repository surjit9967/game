using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class NumberWizard : MonoBehaviour
{
    [SerializeField] int max;
    [SerializeField] int min;
    [SerializeField] TextMeshProUGUI guesstext;
    int guess;
    // Start is called before the first frame update
    void Start()
    {
        StartGame();

    }

    void StartGame()
    {
        NextGuess();
        
       
    }
    
    public void onPressHigher()
    {
        min = guess + 1;

        NextGuess();
    }
    public void onPressLower()
    {
        max = guess-1;
        NextGuess();

    }
   
    
    void NextGuess()
    {

        guess = Random.Range(min, max+1);
        guesstext.text = guess.ToString();

    }
}
