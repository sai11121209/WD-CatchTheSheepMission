using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SheepController : MonoBehaviour
{
    public GameObject sheep;
    private float x, y, z;

    private int sheepCount = 0;
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < 100; i++)
        {
            x = Random.Range(-18.0f, 18.0f);
            y = Random.Range(0.5f, 19.0f);
            z = Random.Range(-18.0f, 18.0f);
            x = 0;
            y = 2;
            z = 22;
            Instantiate(sheep.gameObject, new Vector3(x, y, z), Quaternion.identity);
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
