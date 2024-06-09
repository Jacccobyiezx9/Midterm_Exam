using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HenLay : MonoBehaviour
{
    public GameObject Egg;
    public float layTime = 30f; 
    public int minEggs = 2; 
    public int maxEggs = 10; 

    public float layTimer = 0f;

    void Update()
    {
        layTimer += Time.deltaTime;

        if (layTimer >= layTime)
        {
            LayEggs();
            layTimer = 0f;
        }
    }

    void LayEggs()
    {
        int numEggs = Random.Range(minEggs, maxEggs + 1);

        for (int i = 0; i < numEggs; i++)
        {
            Instantiate(Egg, transform.position, Quaternion.identity);
        }
    }
}
