using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Home : MonoBehaviour
{
    public Text pointText;
    public Text timeText;
    private int point = 100;
    private float countTime = 0; 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        pointText.text = "Point: " + point.ToString();
        timeText.text = "Time: " + countTime.ToString("F2");
        countTime += Time.deltaTime;
    }
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Sheep") {
            Destroy(collision.gameObject);
            point--;
        }
    }
}
