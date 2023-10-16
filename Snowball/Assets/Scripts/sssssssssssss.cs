using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sssssssssssss : MonoBehaviour
{
    public GameObject Target;

    void OnTriggerEnter2D(Collider2D other)
    {
        Target.SetActive(true);
    }

    void OnTriggerExit2D(Collider2D other)
    {
        Target.SetActive(false);
    }
}
