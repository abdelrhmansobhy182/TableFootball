using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ball : MonoBehaviour
{
    
    public Rigidbody2D rb;
    Vector3 lastV;
    
    
    void Update()
    {
        lastV = rb.velocity;
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        var speed = lastV.magnitude;
        var direction = Vector3.Reflect(lastV.normalized, collision.contacts[0].normal);
        rb.velocity = direction * Mathf.Max(speed, 0f);
    }
    

    }
