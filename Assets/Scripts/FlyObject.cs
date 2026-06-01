using UnityEngine;
using System;

public class FlyObject : MonoBehaviour
{
    public GameObject mrRed;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Convert.ToInt32(Time.time) % 10>=5)
            gameObject.transform.position = Vector3.MoveTowards(gameObject.transform.position, mrRed.transform.position, Time.deltaTime * 5);
        else
            gameObject.transform.position = Vector3.MoveTowards(gameObject.transform.position, gameObject.transform.position, Time.deltaTime * 5);
    }
}
