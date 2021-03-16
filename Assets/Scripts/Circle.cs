using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Circle : MonoBehaviour
{
    public Transform player; 
    public Vector3 centerPoint; 
    public float radius;
    float distance;
    Vector3 orginalPoint;



    void Update()
    {

        checkIfInside();
    }

    void checkIfInside()
    {
        distance = Vector3.Distance(player.position, centerPoint);

        if (distance > radius)
        {
            orginalPoint = player.position - centerPoint;
            orginalPoint *= radius / distance;
            player.position = centerPoint + orginalPoint;
            transform.position = player.position;
        }
    }
}

