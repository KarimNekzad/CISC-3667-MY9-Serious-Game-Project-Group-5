using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class StudyTime : MonoBehaviour
{
    private Slider _studyTimeSlider;
    private StressMeter _stressMeter;
    private GPA _gpa;

    private void Awake()
    {
        _studyTimeSlider = GetComponent<Slider>();
        _stressMeter = GameObject.FindGameObjectWithTag("StressMeter").GetComponent<StressMeter>();
        _gpa = GameObject.FindGameObjectWithTag("GPA").GetComponent<GPA>();
    }

    public void MapStudyTimeToResult()
    {
        if (_studyTimeSlider.normalizedValue > 0)
        {
            if (_studyTimeSlider.value == _studyTimeSlider.maxValue)
            {
                _stressMeter.AddStress(2.0f);
            }

            _gpa.IncrementGpa();

            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);
        } 
        else
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            _stressMeter.AddStress(2.0f);
            _gpa.DecrementGpa(0.3f);
        }
    }
}
