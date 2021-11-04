using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Buttons : MonoBehaviour
{
    private const int _mainMenuIndex = 0;
    private const int _settingsIndex = 1;
    private const int _firstQuestionIndex = 2;

    private AudioManager _audioManager;

    private void Awake()
    {
        _audioManager = GameObject.FindGameObjectWithTag("AudioController").GetComponent<AudioManager>();
    }

    public void MainMenu()
    {
        SceneManager.LoadScene(_mainMenuIndex);
        _audioManager.Selection();
    }

    public void Settings()
    {
        SceneManager.LoadScene(_settingsIndex);
        _audioManager.Selection();
    }

    public void FirstQuestion()
    {
        SceneManager.LoadScene(_firstQuestionIndex);
        PlayerPrefs.SetFloat("Stress", 0.0f);
        _audioManager.Selection();
    }

    public void NextQuestion()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        _audioManager.Selection();
    }
}
