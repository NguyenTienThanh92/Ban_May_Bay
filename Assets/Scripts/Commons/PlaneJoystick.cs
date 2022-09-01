﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaneJoystick : MonoBehaviour
{
    public int velocity;
    public Rigidbody2D rb;
    public Joystick joystick;
    public bool touch;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        movePlane();
    }
    private void movePlane()
    {
        Vector2 direction = Vector2.up * joystick.Vertical + Vector2.right * joystick.Horizontal;
        if (touch)
        {
            rb.AddForce(direction * velocity * Time.fixedDeltaTime, ForceMode2D.Impulse);
        }
        else
        {
            gameObject.transform.Translate(direction * velocity * Time.deltaTime);
        }
    }
}
