using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Circle : MonoBehaviour
{
    public Transform player; 
    public Vector3 circleCenter; 
    public float radius;

    void OnDrawGizmosSelected()
    {
        
        Gizmos.color = Color.yellow;
        Gizmos.DrawSphere(transform.position, radius);
    }
    void Update()
    {
       
        float dist = Vector3.Distance(player.position, circleCenter); 

        if (dist > radius)
        {
            Vector3 fromOrigintoObject = player.position - circleCenter;
            fromOrigintoObject *= radius / dist;
            player.position = circleCenter + fromOrigintoObject;
            transform.position = player.position;
        }
    }
}

