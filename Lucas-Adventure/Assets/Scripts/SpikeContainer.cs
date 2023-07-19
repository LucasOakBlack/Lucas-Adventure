using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpikeContainer : MonoBehaviour
{
    public GameObject spikePrefab;
    public int numberofspikes;

    // Start is called before the first frame update
    void Start()
    {
       GenerateSpikes(); 
    }

    // Update is called once per frame
    void GenerateSpikes()
    {
        for (int i = 0; i < numberofspikes; i++)
        {
            GameObject nextSpike = Instantiate(spikePrefab);
            nextSpike.transform.parent = transform;
            nextSpike.transform.position = transform.position + new Vector3(i * 3f, 0, 0);
            GameObject prevSpike = nextSpike;
        }
    }
}
