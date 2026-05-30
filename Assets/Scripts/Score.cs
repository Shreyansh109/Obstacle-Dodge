using UnityEngine;

public class Score : MonoBehaviour
{
    int hits = 0;
    void Start()
    {
       hits=0;
    }
    void OnCollisionExit(Collision collision)
    {
        if(collision.gameObject.name != "Plane")
        {
            hits=hits+1;
            print("You hit the obstacle " + hits + " times!");
        }
    }
}
