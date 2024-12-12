using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class BallMovement : MonoBehaviour
{
    Rigidbody2D rb;
    public float y;
    public float speed;
    public float whenToReset;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        Velocity(Random.Range(-5, 5));
    }

    // Update is called once per frame
    void Update()
    {
        rb.velocity = rb.velocity.normalized * speed;
        TryAgain();
    }

    private void Velocity(float x)
    {
        rb.velocity = new Vector2(x, y);
    }

    private void TryAgain()
    {
        if (transform.position.y <= whenToReset)
        {
            transform.position = new Vector2(0, 0);
            Velocity(Random.Range(-5, 5));
        }
    }

   

}
