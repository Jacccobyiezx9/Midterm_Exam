using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class adultToDeath : MonoBehaviour
{
    public float lifespan = 30f; 
    public float ageTimer = 0f;
    
    void Start()
    { 
        ageTimer = 0f;
    }

    void Update()
    {
        ageTimer += Time.deltaTime;

        if (ageTimer >= lifespan)
        {
            Destroy(gameObject);
        }
    }
}
