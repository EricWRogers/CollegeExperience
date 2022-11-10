using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.VFX;
using TMPro;

public class ProgressBar : MonoBehaviour
{
    //List of Sliders
    public Slider stress;
    public Slider hunger;
    public Slider proficiency; 
    

    public void SliderIncrease(float value, Slider slider) //A function that can be used in other scripts. Must be called like this: ReferenceToScript.SliderIncrease(10,ReferenceToScript.stress);
    {
        slider.value += value;
    }

    public void SliderDecrease(float value, Slider slider)
    {
        slider.value -= value;
    }
    
}
