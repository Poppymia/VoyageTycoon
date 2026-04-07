using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target; // Drag the Ship here
    public float smoothSpeed = 0.125f; // How smoothly the camera follows
    public Vector3 offset; // The distance between the camera and ship

    void LateUpdate()
    {
        if (target != null)
        {
            // Calculate the desired position based on the ship + your offset
            Vector3 desiredPosition = target.position + offset;
            
            // Smoothly move from current position to desired position
            Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);
            
            transform.position = smoothedPosition;
        }
    }
}