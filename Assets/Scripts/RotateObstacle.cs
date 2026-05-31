using UnityEngine;

public class RotateObstacle : MonoBehaviour
{
    
    // Update is called once per frame
    void Update()
    {
        gameObject.transform.Rotate(0, 100*Time.deltaTime , 0);
    }
}
