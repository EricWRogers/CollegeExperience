using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodMovement : MonoBehaviour
{
    public float speed;
    public Rigidbody2D rb;

    public int points = 5;
    
    // Start is called before the first frame update
    void Start()
    {
        rb.velocity = transform.right * speed;
    }

    // Update is called once per frame
    void Update()
    {
        Destroy(gameObject, 5.0f);
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.CompareTag("Bullet"))
        {
            gameObject.SetActive(false);
            FoodScoreManager.instance.AddPoints(points);
            HUD.instance.FoodDestroyed();
        }
    }
}
