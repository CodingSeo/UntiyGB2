using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    public Rigidbody2D rigidbody;
    public float speed;
    void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();
    }

    
    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            AddForce(Vector2.left);        
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            AddForce(Vector2.right);
        }
        if (Input.GetKey(KeyCode.Space))
        {
            rigidbody.AddForce(Vector2.up * speed * Time.deltaTime);
        }
    }

    private void AddForce(Vector2 vector)
    {
        rigidbody.AddForce(vector * speed * Time.deltaTime);
    }
    
}
