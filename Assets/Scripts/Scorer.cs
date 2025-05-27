using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scorer : MonoBehaviour
{
    int hits = 0;

    private void OnCollisionEnter(Collision collision)
    {
        hits=hits+1;
        if (collision.gameObject.tag != "Hit")
        {
            Debug.Log("Hits: " + hits);
        }
    }
}
