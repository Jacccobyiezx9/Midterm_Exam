using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class chickToAdult : MonoBehaviour
{
    public float growTime;
    public float startTime;
    public GameObject Chick, Hen, Rooster;
    private static int chickCount = 0;

    // Start is called before the first frame update
    void Start()
    {
        startTime = 0f;
    }

    // Update is called once per frame
    void Update()
    {
        startTime += Time.deltaTime;
        ChickToAdult();
    }

    void ChickToAdult()
    {
        if (startTime >= growTime)
        {
            GameObject grownAdult;

            if (chickCount == 0)
            {
                grownAdult = Instantiate(Hen, Chick.transform.position, Chick.transform.rotation);
            }
            else
            {
                if (Random.value < 0.5f)
                {
                    grownAdult = Instantiate(Hen, Chick.transform.position, Chick.transform.rotation);
                }
                else
                {
                    grownAdult = Instantiate(Rooster, Chick.transform.position, Chick.transform.rotation);
                }
            }

            chickCount++;
            Destroy(Chick);
        }
    }
}
