using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Calendar 
{
 
    public enum DAY { DAY1 = 1, DAY2 = 2, DAY3 = 3, DAY4 = 4, DAY5 = 5, DAY6 = 6, DAY7 = 7} //List of game states
    public enum TIME { THREEPM = 1, SIXPM = 2, NINEPM = 3, TWELVEPM = 4} //List of times

    public DAY currentDay;
    public TIME currentTime;
    void Start()
    {
        currentDay = DAY.DAY1;
        currentTime = TIME.THREEPM;
    }

    void ProgressDay(int _index)
    {
        currentDay = (DAY)_index;
    }

    void ProgressTime(int _index)
    {
        currentTime = (TIME)_index;
    }
    
}
