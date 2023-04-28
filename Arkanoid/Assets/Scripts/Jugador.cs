using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jugador : MonoBehaviour
{

    public Rigidbody2D ribidbody2D;

    private float inputValue;

    public float movespeed = 25;

    private Vector2 direction;

    Vector2 startPosition;

    private void Start()
    {
        startPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        inputValue = Input.GetAxisRaw("Horizontal");

        if (inputValue == 1)
        {
            direction = Vector2.right;
        }
        else if (inputValue == -1)
        {
            direction = Vector2.left;
        }
        else
        {
            direction = Vector2.zero;
        }

        ribidbody2D.AddForce(direction * movespeed * Time.deltaTime * 100);
      

    }

    public void ResetJugador()
    {
        transform.position = startPosition;
        ribidbody2D.velocity = Vector2.zero;
    }
}
