using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StressIncreaser : MonoBehaviour
{
    public ProgressBar PB;
    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("Pressed");
            PB.SliderIncrease(10f, PB.stress);
            Debug.Log("Increased");
        }

        if (Input.GetKeyDown(KeyCode.Tab))
        {
            Debug.Log("Pressed");
            PB.SliderDecrease(10f, PB.hunger);
            Debug.Log("Decreased");
        }

    }
}
