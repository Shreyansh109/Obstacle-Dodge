using UnityEngine;

public class Drive : MonoBehaviour
{
    float xValue = 0f;
    float zValue = 0f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        xValue = Input.GetAxis("Horizontal");
        zValue = Input.GetAxis("Vertical");
        transform.Translate(xValue * Time.deltaTime *10, 0f, zValue * Time.deltaTime *10);
        print(Time.time);
    }
}
