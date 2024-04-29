using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public float smoothSpeed = 0.125f;
    public Vector3 offset;

    private Transform target;

    void Start()
    {
        target = GameManager.Instance.player.transform;
    }

    void LateUpdate()
    {
        Vector3 desiredPosition = target.position + offset;
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);
        transform.position = smoothedPosition;

        transform.LookAt(target);
    }
}
