using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GPA : MonoBehaviour
{
    [SerializeField] private Text _gpaText;

    private float _gpa;
    public float _gpaIncrement = 0.2f;

    private void Awake()
    {
        if (PlayerPrefs.HasKey("GPA"))
        {
            _gpa = PlayerPrefs.GetFloat("GPA");
        }
        else
        {
            _gpa = 3.1f;
            PlayerPrefs.SetFloat("GPA", _gpa);
        }

        _gpaText.text = "GPA: " + _gpa;
    }

    public void SetGpa(float value)
    {
        if (value >= 0.0f || value <= 4.0f)
        {
            _gpa = value;
            PlayerPrefs.SetFloat("GPA", _gpa);
        }
    }

    public void IncrementGpa()
    {
        _gpa += _gpaIncrement;
        PlayerPrefs.SetFloat("GPA", _gpa);
    }

    public void DecrementGpa()
    {
        _gpa -= _gpaIncrement;
        PlayerPrefs.SetFloat("GPA", _gpa);

        if (_gpa < 2.6)
        {
            Debug.Log("GPA is very low");
        }
    }

    public void BuffGpa() {
        _gpaIncrement = 0.6f;
    }
}
