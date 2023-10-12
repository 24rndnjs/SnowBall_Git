using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collisiondetection : MonoBehaviour
{
    public GameObject Target1;
    public GameObject Target2;

    void OnTriggerEnter2D(Collider2D other)
    {
        Target1.SetActive(true);
        Target2.SetActive(true);
    }

    void OnTriggerExit2D(Collider2D other)
    {
        Target1.SetActive(false);
        Target2.SetActive(false);
    }
}
