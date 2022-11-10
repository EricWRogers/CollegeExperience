using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HungerBar : MonoBehaviour
{
    public Slider slider;

    public void SetMinHunger(int hunger)
    {
        slider.minValue = hunger;
        slider.value = hunger;
    }

    public void SetHunger(int hunger)
    {
        slider.value = hunger;
    }
}
