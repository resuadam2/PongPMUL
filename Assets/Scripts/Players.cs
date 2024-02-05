using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Players : MonoBehaviour
{
    public bool player1; // This is set in the inspector
    public float speed = 3f; // This is set in the inspector
    public Rigidbody2D rb; // This is set in the inspector

    private float movement = 0f; // This is set in the inspector
    private Vector2 startPos; // This is set in the inspector

    public float moveSpeedTouch = 0.03f; // This is set in the inspector

    // Start is called before the first frame update
    void Start()
    {
        startPos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if(player1)
        {
            if(Input.GetMouseButton(0)) // Controls the player with the mouse and in touch screen
            {
                Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition); // Get the mouse position in the world
                if (mousePosition.x < 1) // If the mouse is in the right half of the screen
                {
                    if(mousePosition.y > 0.5) // If the mouse is in the top half of the screen
                    {
                        transform.Translate(Vector3.up * moveSpeedTouch); // Move the player up
                    }
                    else if (mousePosition.y < 0.5)
                    {
                        transform.Translate(Vector3.down * moveSpeedTouch); // Move the player up
                    }                 
                }
            }
            movement = Input.GetAxisRaw("Vertical2"); 
        }
        else
        {
            if (Input.GetMouseButton(0)) // Controls the player with the mouse and in touch screen
            {
                Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition); // Get the mouse position in the world
                if (mousePosition.x > 1) // If the mouse is in the right half of the screen
                {
                    if (mousePosition.y > 0.5) // If the mouse is in the top half of the screen
                    {
                        transform.Translate(Vector3.up * moveSpeedTouch); // Move the player up
                    }
                    else if (mousePosition.y < 0.5)
                    {
                        transform.Translate(Vector3.down * moveSpeedTouch); // Move the player up
                    }
                }
            }
            movement = Input.GetAxisRaw("Vertical");
        }

        rb.velocity = new Vector2(rb.velocity.x, movement * speed); // Move the player up or down
    }

    // Reset the player to the starting position
    public void Reset()
    {
        rb.velocity = Vector2.zero;
        transform.position = startPos;
    }
}
