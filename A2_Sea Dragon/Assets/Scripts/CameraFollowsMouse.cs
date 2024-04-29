using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollowsMouse : MonoBehaviour
{
    public class FpsCamera : MonoBehaviour
    {
        public float sensitivity = 5f;
        private void Start()
        {

        }
        private void Update()
        {
            float horizontalInput = Input.GetAxis("Mouse X");
            float verticalInput = Input.GetAxis("Mouse Y");

            transform.Rotate(Vector3.up * horizontalInput * sensitivity);
            transform.Rotate(Vector3.right * -verticalInput * sensitivity);
            Vector3 desiredPosition = gameObject.transform.position + Vector3.back * 2f + Vector3.up * 1f;
            transform.position = Vector3.Lerp(transform.position, desiredPosition, Time.deltaTime * 5f);
        }
    }

}
