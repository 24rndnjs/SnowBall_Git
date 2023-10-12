using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OUT : MonoBehaviour
{
    public GameObject Target1;

    void OnTriggerEnter2D(Collider2D other)
    {
        Target1.SetActive(true);
    }

    void OnTriggerExit2D(Collider2D other)
    {
        Target1.SetActive(false);
    }
}
