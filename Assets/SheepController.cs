using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SheepController : MonoBehaviour
{
    public GameObject sheep;
    // Start is called before the first frame update
    void Start()
    {
        float x, y, z;

        for(int i=0; i<101; i++) {
            x = Random.Range(-19.0f, 19.0f);
            y = 0.5f;
            z = Random.Range(-19.0f, 19.0f);

            Instantiate(sheep.gameObject, new Vector3(x, y, z), Quaternion.identity);
        }
    }

    // Update is called once per frame
    void Update()
    {
    }
}
