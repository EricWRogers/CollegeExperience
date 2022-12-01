using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class StudyHUD : MonoBehaviour
{
    public static StudyHUD instance;

    public TMP_Text studyText;

    public TMP_Text timerText;

    public int maxPoints = 1000;

    private int points = 0;

    void Awake()
    {
        if (instance == null)
            instance = this;
        else
            Destroy(this);
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void WordsAbsorbed()
    {
        points++;
    }
}
