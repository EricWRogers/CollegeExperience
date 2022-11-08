using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class HUD : MonoBehaviour
{
    public static HUD instance;

    public TMP_Text hungerText;

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

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        if (FoodScoreManager.instance != null)
            hungerText.text = "Hunger: " + FoodScoreManager.instance.score;

        //winText.gameObject.SetActive(gold >= maxGold);
    }

    public void FoodDestroyed()
    {
        points++;
    }
}
