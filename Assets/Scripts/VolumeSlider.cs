using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class VolumeSlider : MonoBehaviour
{
    [SerializeField] AudioMixer _audioMixer;
    [SerializeField] Slider _slider;
    [SerializeField] float _volumeMultiplier = 30f;

    public void Awake()
    {
        _slider.onValueChanged.AddListener(HandlesValueChange);
    }

    public void HandlesValueChange(float volume)
    {
        //AudioListener.volume = volume;
        _audioMixer.SetFloat("BgVolume", Mathf.Log10(volume) * _volumeMultiplier);
    }
}
