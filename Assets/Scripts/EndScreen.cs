using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EndScreen : MonoBehaviour
{
    [SerializeField] private Text _endScreen;

    private float _gpa;
    public const float _gpaIncrement = 0.1f;

    // Start is called before the first frame update
    private void Awake()
    {

        _gpa = PlayerPrefs.GetFloat("GPA");


        
    }

    public void Start() {
        if (_gpa > 3.0f)
        {
            _endScreen.text = "Your GPA was high enough for you to graduate with your desired degree!" +
                "\nVictory!";
        }
        else
        {
            _endScreen.text = "Your GPA was not high enough for you to graduate with your desired degree!" +
    "\nDefeat";
        }
    }
}
