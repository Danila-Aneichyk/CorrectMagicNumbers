using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement; 

public class SecondLevel : MonoBehaviour
{
    private int _counter = 0;
    private int _firstValue = 0;
    private int _secondValue = 0;




    public TextMeshProUGUI CalculatingLabel;
    public TextMeshProUGUI TapInfoLabel;

    public Button RestartButton; 
    public Button FirstButton;
    public Button SecondButton;
    public Button ThirdButton;
    public Button FourthButton;
    public Button FifthButton;
    public Button SixthButton;
    public Button SeventhButton;
    public Button EighthButton;
    public Button NinethButton;
    
    
    
    void Start()
    {
        RestartButton.onClick.AddListener(RestartButtonClicked);     
        FirstButton.onClick.AddListener(FirstButtonClicked);
        SecondButton.onClick.AddListener(SecondButtonClicked);
        ThirdButton.onClick.AddListener(ThirdButtonClicked);
        FourthButton.onClick.AddListener(FourthButtonClicked);
        FifthButton.onClick.AddListener(FifthButtonClicked);
        SixthButton.onClick.AddListener(SixthButtonClicked);
        SeventhButton.onClick.AddListener(SeventhButtonClicked);
        EighthButton.onClick.AddListener(EighthButtonClicked);
        NinethButton.onClick.AddListener(NinethButtonClicked);
    }

    private void RestartButtonClicked()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 0);
    }

    void Update()
    {
           GiveTapInfo($"Numbers of taps: {_counter}");
           
    }

    private void Calculating(string text)
    {
        Debug.Log(text);
        CalculatingLabel.text = text;
    }
    private void GiveTapInfo(string text)
    {
        Debug.Log(text);
        TapInfoLabel.text = text;
    }

    private void NinethButtonClicked()
    {
        Debug.Log("Nineth button clicked");
        _counter++;
        _firstValue = 9;
        _secondValue = 9;
    }

    private void EighthButtonClicked()
    {
        Debug.Log("Eighth button clicked");
        _counter++;
        _firstValue = 8;
        _secondValue = 8; 
    }

    private void SeventhButtonClicked()
    {
        Debug.Log("Seventh button clicked");
        _counter++;
    }

    private void SixthButtonClicked()
    {
        Debug.Log("Sixth button clicked");
        _counter++;
    }

    private void FifthButtonClicked()
    {
        Debug.Log("Fifth button clicked");
        _counter++;
    }

    private void FourthButtonClicked()
    {
        Debug.Log("Fourth button clicked");
        _counter++;
    }

    private void ThirdButtonClicked()
    {
        Debug.Log("Third button clicked");
        _counter++;
    }

    private void SecondButtonClicked()
    {
        Debug.Log("Second button clicked");
        _counter++;
    }

    private void FirstButtonClicked()
    {
        Debug.Log("First button clicked");
        _counter++;
        
    }

   
}
