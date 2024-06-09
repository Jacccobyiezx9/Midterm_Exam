using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class eggToChick : MonoBehaviour
{

    public float hatchTime;
    public float startTime;
    public GameObject Egg, Chick;
    // Start is called before the first frame update
    void Start()
    {
        startTime = 0f;
    }

    // Update is called once per frame
    void Update()
    {
        startTime += Time.deltaTime;
        EggToChick();
    }

    void EggToChick()
    {
        if (startTime >= hatchTime)
        {
            GameObject hatchedChick = Instantiate(Chick, transform.position, transform.rotation);
            Destroy(Egg);
        }
    }
}