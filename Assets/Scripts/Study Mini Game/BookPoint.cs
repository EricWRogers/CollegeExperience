using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BookPoint : MonoBehaviour
{
    public int points;

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTriggerEnter2D(Collider2D col)
    {
        if (Input.GetButtonDown("Fire1"))
        {
            gameObject.SetActive(false);
            StudyScoreManager.instance.AddPoints(points);
            //StudyHUD.instance.FoodDestroyed();
        }
    }

    public void AddPoints(int amount)
    {
        points += amount;
    }
}
