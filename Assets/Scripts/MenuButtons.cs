using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuButtons : MonoBehaviour
{
    private const int _mainMenuIndex = 0;
    private const int _settingsIndex = 1;
    private const int _firstQuestionIndex = 2;

    public void MainMenu()
    {
        SceneManager.LoadScene(_mainMenuIndex);
    }

    public void Settings()
    {
        SceneManager.LoadScene(_settingsIndex);
    }

    public void FirstQuestion()
    {
        SceneManager.LoadScene(_firstQuestionIndex);
    }
}
