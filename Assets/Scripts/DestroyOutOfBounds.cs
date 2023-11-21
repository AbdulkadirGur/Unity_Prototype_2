using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    public float topBound = 30.0f;
    public float lowerBound = -15.0f;
    void Start()
    {
        
    }

   
    void Update()
    {
        if (transform.position.z >topBound)
        {
            Destroy(gameObject);
        }
        else if (transform.position.z <lowerBound) { Destroy(gameObject); }
    }
}
