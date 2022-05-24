using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class MagicNumbers : MonoBehaviour
{
    [SerializeField] private int Min = 1;
    [SerializeField] private int Max = 1000;
    private int _guess;
    private int _counter;

    public TextMeshProUGUI InfoLabel;
    public TextMeshProUGUI GuessLabel;
    public TextMeshProUGUI TapInfoLabel;
    public Button MoreButton;
    public Button LessButton;
    public Button FinishButton;

    private void Start()
    {
        MoreButton.onClick.AddListener(MoreButtonClicked);
        LessButton.onClick.AddListener(LessButtonClicked);
        FinishButton.onClick.AddListener(FinishButtonClicked);
      
        SetInfoText($"Guess number from {Min} to {Max}");
        CalculateGuess();

    }

    private void Update()
    {
        GiveTapInfo($"Number of taps: {_counter}");  
    }

    private void CalculateGuess()
    {
        _guess = (Min + Max) / 2;

        SetGuess($"Your number: {_guess}?");
    }

    private void SetInfoText(string text)
    {
        Debug.Log(text);

        InfoLabel.text = text;
    }
   
    private void SetGuess(string text)
    {
        Debug.Log(text);

        GuessLabel.text = text;
    }
   
    private void MoreButtonClicked()
    {
        Debug.Log("MoreButtonClicked");
        Debug.Log(_counter);
        Min = _guess;
        CalculateGuess();
        _counter++;
    }

    private void LessButtonClicked()
    {
        Debug.Log("LessButtonClicked");
        Debug.Log(_counter);
        Max = _guess;
        CalculateGuess();
        _counter++;
    }

    private void FinishButtonClicked()
    {
        Debug.Log("FinishButtonClicked");
        Debug.Log(_counter);
        SetInfoText($"I guessed! your number: {_guess}");
        _counter++;
    }


    public void GiveTapInfo(string text)
    {
        Debug.Log(text);
        TapInfoLabel.text = text;
    }
}