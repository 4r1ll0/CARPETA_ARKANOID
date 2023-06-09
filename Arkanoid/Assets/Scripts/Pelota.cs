using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pelota : MonoBehaviour
{
    public Rigidbody2D rigidBody2D;

    public float speed = 300;

    private Vector2 velocity;

    Vector2 starPosition;

    void Start()
    {
        starPosition=transform.position;
        ResetPelota();
        

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("DeadZone"))
        {
            FindObjectOfType<GameManager>().LosseHealht();

        }



        
    }

    public void ResetPelota()
    {
        transform.position = starPosition;
        rigidBody2D.velocity = Vector2.zero;

        velocity.x = Random.Range(-1f, 1f);

        velocity.y = 1;

        rigidBody2D.AddForce(velocity * speed);
    }
}

