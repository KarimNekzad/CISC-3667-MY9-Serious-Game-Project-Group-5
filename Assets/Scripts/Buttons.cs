using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Buttons : MonoBehaviour
{
    private const int _mainMenuIndex = 0;
    private const int _settingsIndex = 1;
    private const int _firstQuestionIndex = 3;
    private const float _defaultGpa = 3.1f;
    private const float _defaultStress = 0.0f;

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
        SetInitialValues();
        _audioManager.Selection();
    }

    private void SetInitialValues()
    {
        PlayerPrefs.SetFloat("Stress", _defaultStress);
        PlayerPrefs.SetFloat("GPA", _defaultGpa);
    }

    public void AdvanceOnce()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        _audioManager.Selection();
    }

    public void AdvanceTwice()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);
        _audioManager.Selection();
    }

    public void AdvanceThree()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 3);
        _audioManager.Selection();
    }

    public void AdvanceFour()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 4);
        _audioManager.Selection();
    }
}
