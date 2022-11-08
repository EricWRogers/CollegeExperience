using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodScoreManager : MonoBehaviour
{
    public static FoodScoreManager instance;

    public int score = 0;
    public HungerBar hungerBar;

    void Awake()
    {
        if (instance == null)
            instance = this;
        else
            Destroy(this);
    }

    public void AddPoints(int amount)
    {
        score += amount;
        hungerBar.slider.value = score;
    }
}
