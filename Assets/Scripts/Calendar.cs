using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Calendar:MonoBehaviour
{
 
    public enum DAY { DAY1 = 1, DAY2 = 2, DAY3 = 3, DAY4 = 4, DAY5 = 5, DAY6 = 6, DAY7 = 7} //List of game states
    public enum TIME { THREEPM = 1, SIXPM = 2, NINEPM = 3, TWELVEPM = 4} //List of times
    public TMP_Text timeText;

    public DAY currentDay;
    public TIME currentTime;
    void Start()
    {
        ProgressDay ((int)DAY.DAY1);
        ProgressTime ((int)TIME.THREEPM);
        TimeChange();
    }
    void TimeText()
    {
        timeText.text = "Day: " + (int)currentDay + " Time: " + currentTime;
    }

    void ProgressDay(int _index)
    {
        currentDay = (DAY)_index;
        TimeText();
    }

    void ProgressTime(int _index)
    {
        currentTime = (TIME)_index;
        TimeText();
    }
    
    void TimeChange()
    {
        currentTime = (TIME)((int)currentTime + 1);
        if ((int)currentTime > 4)
        {
            currentTime = (TIME)(1);
            currentDay = (DAY)((int)currentDay + 1);
            TimeText();
        }
        TimeText();
    }
}
