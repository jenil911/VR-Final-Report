using UnityEngine;

public class WaypointIndicator : MonoBehaviour
{
    public Transform target; // The target object to point towards

    void Update()
    {
        if (target != null)
        {
            // Calculate the direction from the indicator to the target, ignoring the Y axis
            Vector3 direction = target.position - transform.position;
            direction.y = 0; // Set Y component to 0 to keep it in 2D space

            if (direction != Vector3.zero)
            {
                // Rotate the indicator to face the target only in 2D space
                float angle = Mathf.Atan2(direction.x, direction.z) * Mathf.Rad2Deg;
                transform.rotation = Quaternion.Euler(new Vector3(0, -angle, 0));
            }
        }
    }
}
