using UnityEngine;

public class TouchEffector : MonoBehaviour
{
    void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.name != "Plane")
            collision.gameObject.GetComponent<MeshRenderer>().material.color = Color.red;
    }
}
