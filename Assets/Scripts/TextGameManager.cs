using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement; 

public class TextGameManager : MonoBehaviour
{
    public TextMeshProUGUI displayText; 
    private int currentIndex = 0;

    private string[] storyLines = {
        "The rain is getting stronger..",
        "I should head home while it's still early.",
    };

    void Start()
    {
        UpdateText();
    }

    public void OnNextButtonClicked()
    {
        if (currentIndex < storyLines.Length - 1)
        {
            currentIndex++;
            UpdateText();
        }
        else
        {
            SceneManager.LoadScene("Scene2"); 
        }
    }

    private void UpdateText()
    {
        displayText.text = storyLines[currentIndex];
    }
}
