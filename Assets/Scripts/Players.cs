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
            movement = Input.GetAxisRaw("Vertical2"); 
        }
        else
        {
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
