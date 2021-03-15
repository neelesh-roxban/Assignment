using System.Collections;
using System.Collections.Generic;
using UnityEngine;




public class Projectile : MonoBehaviour
{

    
    
    Rigidbody2D rb;

    public float dgrees;
    float angle;
    
    public float force;
    Vector2 direction;
   
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();       
       
    }

    private void Update()
    {
        getDirection();
        move();

    }

    
    void getDirection()
    {
        angle = dgrees * Mathf.Deg2Rad;
        direction.x = Mathf.Cos(angle);
        direction.y = Mathf.Sin(angle);

    }
    private void move()
    {
        
        if (Input.GetKeyDown(KeyCode.Space))
        {
          
            rb.velocity =direction.normalized * force;
        }
    }
    
   
}
