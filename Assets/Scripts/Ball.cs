using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public float speed = 3f; // This is set in the inspector
    public Rigidbody2D rb; // This is set in the inspector
    private Vector2 startPos; // This is set in the inspector

    // Start is called before the first frame update
    void Start()
    {
        startPos = transform.position;
        Launch();
    }

    // Launch the ball in a random direction
    public void Launch()
    {
        float x = Random.Range(0, 2) == 0 ? -1 : 1; // Randomly choose -1 or 1
        float y = Random.Range(0, 2) == 0 ? -1 : 1; // Randomly choose -1 or 1
        rb.velocity = new Vector2(speed * x, speed * y);
    }

    // Reset the ball to the starting position and launch it again
    public void Reset()
    {
        rb.velocity = Vector2.zero;
        transform.position = startPos;
        Launch();
    }
}
