using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collisiondetection : MonoBehaviour
{
    private bool isOverlapped = false;
    private Renderer triggerRenderer;

    private Color originColor;

    void Start()
    {
        triggerRenderer = GetComponent<Renderer>();
        originColor = triggerRenderer.material.color;
    }
    private void OnTriggerStay2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            isOverlapped = true;
            triggerRenderer.material.color = Color.red;
        }
    }
}
