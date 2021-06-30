using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class UIController : MonoBehaviour
{
    [SerializeField] Slider picthSlider;
    [SerializeField] TextMeshProUGUI pitchvalue;

    public void OnPitchValueChanged()
    {
        pitchvalue.text = picthSlider.value.ToString();
        if (GameController.OnPitchValueChanged!=null)
    GameController.OnPitchValueChanged(picthSlider.value);
    }
    private void OnEnable()
    {
        pitchvalue.text = picthSlider.value.ToString();

    }

 
}
