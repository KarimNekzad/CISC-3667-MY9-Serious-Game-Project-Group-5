using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StressMeter : MonoBehaviour
{
    private Slider _stressMeter;

    private const float _defaultStress = 1.0f;

    private void Awake()
    {
        _stressMeter = GetComponent<Slider>();

        if (PlayerPrefs.HasKey("Stress"))
        {
            _stressMeter.value = PlayerPrefs.GetFloat("Stress");
        }
        else
        {
            _stressMeter.value = 0;
        }
    }

    public void SetMeterValue(int value)
    {
        _stressMeter.value = value;
        PlayerPrefs.SetFloat("Stress", _stressMeter.value);
    }

    public void AddStress()
    {
        _stressMeter.value += _defaultStress;
        PlayerPrefs.SetFloat("Stress", _stressMeter.value);

        if (_stressMeter.value == _stressMeter.maxValue)
        {
            Debug.Log("Player stress is at maximum");
        }
    }

    public void SubtractStress()
    {
        _stressMeter.value -= _defaultStress;
        PlayerPrefs.SetFloat("Stress", _stressMeter.value);
    }
}
