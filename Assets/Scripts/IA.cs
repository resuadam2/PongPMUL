using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IA : MonoBehaviour
{
    [SerializeField] private float speed = 3f;

    public GameObject ball;

    private Vector2 ballPosition;

    void Start()
    {
        
    }

    void Update()
    {
        Movement();
    }

    private void Movement()
    {
        ballPosition = ball.transform.position; // Posici�n de la pelota

        if(transform.position.y > ballPosition.y) // Si la posici�n de la IA es mayor que la de la pelota, se mueve hacia abajo
        {
            transform.Translate(Vector2.down * speed * Time.deltaTime);
            // Tambi�n se podr�a hacer as�: transform.position += new Vector3(0, -speed * Time.deltaTime, 0);
        }
        else if(transform.position.y < ballPosition.y) // Si la posici�n de la IA es menor que la de la pelota, se mueve hacia arriba
        {
            transform.Translate(Vector2.up * speed * Time.deltaTime);
        }
    }
}
