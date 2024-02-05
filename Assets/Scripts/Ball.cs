using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public float speed = 3f; // This is set in the inspector
    public Rigidbody2D rb; // This is set in the inspector
    private Vector2 startPos; // This is set in the inspector
    public float speedIncrease = 0.1f; // This is set in the inspector

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

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            rb.velocity *= 1 + speedIncrease;
        }
        VelocityFix();
    }

    private void VelocityFix()
    {
        float velocidadDelta = 0.5f; // Velocidad que queremos que aumente la bola
        float velocidadMinima = 0.2f; // Velocidad mínima que queremos que tenga la bola

        if (Mathf.Abs(rb.velocity.x) < velocidadMinima) // Si la velocidad de la bola en el eje x es menor que la mínima
        {
            velocidadDelta = Random.value < 0.5f ? velocidadDelta : -velocidadDelta; // Elegimos un valor aleatorio entre -0.5 y 0.5
            rb.velocity = new Vector2(rb.velocity.x + velocidadDelta, rb.velocity.y); // Aumentamos la velocidad de la bola
        }

        if (Mathf.Abs(rb.velocity.y) < velocidadMinima) // Si la velocidad de la bola en el eje y es menor que la mínima
        {
            velocidadDelta = Random.value < 0.5f ? velocidadDelta : -velocidadDelta; // Elegimos un valor aleatorio entre -0.5 y 0.5
            // Otra forma de aumentar la velocidad (esta vez en el eje y)
            rb.velocity += new Vector2(0f, velocidadDelta); // Aumentamos la velocidad de la bola
        }
    }

}
