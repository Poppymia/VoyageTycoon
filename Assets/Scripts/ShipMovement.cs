using UnityEngine;
using System.Collections.Generic;

public class ShipMovement : MonoBehaviour
{
    public List<Transform> waypoints; // Drag your Point1, Point2, etc. here
    public float sailSpeed = 5.0f;    // Increase this for "move faster"
    public float rotationSpeed = 2.0f; 
    
    private int currentPointIndex = 0;
    public bool isSailing = false;

    void Update()
    {
        if (isSailing && currentPointIndex < waypoints.Count)
        {
            Transform target = waypoints[currentPointIndex];

            // 1. Move the ship toward the current waypoint
            transform.position = Vector2.MoveTowards(transform.position, target.position, sailSpeed * Time.deltaTime);

            // 2. Rotate the ship to face the direction it's moving (Optional but looks better)
            Vector3 direction = target.position - transform.position;
            if (direction != Vector3.zero)
            {
float angle = (Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg) - 90f;                Quaternion targetRotation = Quaternion.AngleAxis(angle, Vector3.forward);
                transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, rotationSpeed * Time.deltaTime);
            }

            // 3. Check if we reached the point, then move to the next one
            if (Vector2.Distance(transform.position, target.position) < 0.2f)
            {
                currentPointIndex++;
            }
        }
        else if (currentPointIndex >= waypoints.Count)
        {
            isSailing = false; // Stop when the last point is reached
        }
    }
}