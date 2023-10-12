using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using UnityEngine;
public Vector2 Size;
public LayerMask WhatIsLayer;


public class Collisiondetection : MonoBehaviour
{
    //Vector2 point, Vector2 size, float angle, int layerMask
    Collider2D Physics2D.OverlapBox(point, size, angle);
    Collider2D Physics2D.OverlapBox(point, size, angle, layerMask);
    void Start()
    {
        Collider2D hit = Physics2D.OverlapBox(transform.position, size, 0, whatIsLayer);
        Debug.Log(hit.name);
    }

    void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireCube(transform.position, size);
    }
}
