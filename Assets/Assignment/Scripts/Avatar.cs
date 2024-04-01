using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Avatar : MonoBehaviour
{
    Vector2 direction;
    Rigidbody2D rigidbody;
    int health = 4;
    protected SpriteRenderer spriteRenderer;
    public float force = 10f;
    protected bool isSelected;

    protected virtual void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();
        spriteRenderer = GetComponent<SpriteRenderer>();
    }
    protected virtual void Update()
    {
        if (isSelected)
        {
            direction.x = Input.GetAxis("Horizontal");
            direction.y = Input.GetAxis("Vertical");
            if (Input.GetKeyDown(KeyCode.Space))
            {
                Special();
            }
        }
    }
    private void FixedUpdate()
    {
        rigidbody.AddForce(direction * force * Time.deltaTime);
    }

    protected virtual void Special()
    {
        
    }

    public void Selected(bool value)
    {
        if(value) { 
            force = 700;
        }
        isSelected = value;
    }
}
