using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class SliderValueToText : MonoBehaviour
{
    public Slider sliderUI;
    public Text textSliderValue;

    public Gradient _gradient;
    public Image _fill;

    void Update()
    {
        textSliderValue.text = sliderUI.value.ToString();
        _fill.color = _gradient.Evaluate(sliderUI.normalizedValue);
    }
}
