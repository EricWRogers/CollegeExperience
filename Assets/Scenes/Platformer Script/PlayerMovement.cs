using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float speed;
    private Rigidbody2D body;
    public bool isJumping;
    public float jump;
    private void Awake()
    {
        body = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        body.velocity = new Vector2(Input.GetAxis("Horizontal")* speed, body.velocity.y);

        if (Input.GetButtonDown("Jump")&& isJumping == false)
        {
            body.AddForce(new Vector2(body.velocity.x, jump));
            Debug.Log("jump");
        }
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Ground"))
        {
            isJumping = false;
        }
        if (other.gameObject.CompareTag("mGround"))
        {
            this.transform.parent = other.transform;
            isJumping = false;
        }

    }

    private void OnCollisionExit2D(Collision2D other)
    {
        if(other.gameObject.CompareTag("Ground"))
        {
            isJumping = true;
        }
        if (other.gameObject.CompareTag("mGround"))
        {
            this.transform.parent = null;
            isJumping = true;
        }
    }
}
