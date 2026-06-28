using UnityEngine;

public class AnubisCamera : MonoBehaviour
{
    // Drag your Main Camera here in the Inspector
    public Camera mainCamera;

    void LateUpdate()
    {
        // This camera copies the position and rotation of Main Camera every frame
        transform.position = mainCamera.transform.position;
        transform.rotation = mainCamera.transform.rotation;
    }
}