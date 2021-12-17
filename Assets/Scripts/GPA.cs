using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GPA : MonoBehaviour
{
    [SerializeField] private Text _gpaText;
    //[SerializeField] private Text _endScreen;

    private float _gpa;
    public const float _gpaIncrement = 0.1f;

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

    public void IncrementGpa(float increment)
    {
        if (IsValidGpaModifier(increment))
        {
            _gpa += increment;
        }
        else
        {
            Debug.Log("That GPA modifier value is invalid!");
        }
        
        PlayerPrefs.SetFloat("GPA", _gpa);
    }

    public void IncrementGpa()
    {
        _gpa += _gpaIncrement;
        PlayerPrefs.SetFloat("GPA", _gpa);
    }

    public void DecrementGpa(float decrement)
    {
        if (IsValidGpaModifier(decrement))
        {
            _gpa -= decrement;
        }
        else
        {
            Debug.Log("That GPA decrement is invalid!");
        }
        
        PlayerPrefs.SetFloat("GPA", _gpa);

        if (_gpa < 2.6)
        {
            Debug.Log("GPA is very low");
        }
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

    private bool IsValidGpaModifier(float modifier)
    {
        if (modifier >= 0 && modifier <= 4)
        {
            if (_gpa + modifier > 4 || _gpa - modifier < 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        } 
        else
        {
            return false;
        }
    }


}
