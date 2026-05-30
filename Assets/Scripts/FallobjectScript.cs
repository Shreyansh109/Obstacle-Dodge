using UnityEngine;
using System;

public class FallobjectScript : MonoBehaviour
{
    float xPosition = 0f;
    float yPosition = 10f;
    float zPosition = 0f;
    void Start()
    {
        xPosition = gameObject.transform.position.x;
        yPosition = gameObject.transform.position.y;
        zPosition = gameObject.transform.position.z;
    }

    // Update is called once per frame
    void Update()
    {
        Convert.ToInt32(Time.time);
        if(Convert.ToInt32(Time.time) % 5 == 0 && Convert.ToInt32(Time.time) != 0)
        {
            Convert.ToInt32(Time.time);
            gameObject.GetComponent<Rigidbody>().useGravity = true;
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        gameObject.GetComponent<Rigidbody>().useGravity = false;
        gameObject.transform.position = new Vector3(xPosition, yPosition, zPosition);
    }
}
