using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstEgg : MonoBehaviour
{
    public GameObject eggPrefab;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(eggPrefab, transform.position, transform.rotation);
        }
    }
}
