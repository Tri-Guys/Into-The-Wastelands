using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class RangeScript : MonoBehaviour
{
    public Transform other;

    void Example()
    {
        if (other)
        {
            float dist = Vector3.Distance(other.position, transform.position);
            //print("Distance to other: " + dist);
            Debug.Log(dist);
        }
    }
}