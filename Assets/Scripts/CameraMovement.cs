using System.Collections;
using System.Collections.Generic;
using UnityEngine;




public class CameraMovement : MonoBehaviour
{
    [SerializeField] Transform target;  // Reference to the player spaceship transform
    [SerializeField] float smoothSpeed = 0.125f;  // Adjust this to control the smoothness of camera follow
    [SerializeField] Vector3 offset;  // Offset from the spaceship to the camera

    void LateUpdate()
    {
        Vector3 desiredPosition = target.position + offset;
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);
        transform.position = smoothedPosition;

        transform.LookAt(target);  // Make the camera look at the spaceship
    }
}
