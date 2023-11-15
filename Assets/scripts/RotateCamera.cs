using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target;  // The player's Transform
    public Vector3 offset;    // The offset from the player
    public float smoothSpeed = 50.0f;  // The smoothness of camera movement
    public float rotationSpeed = 150.0f;  // The speed at which the camera follows player rotation

    private Vector3 desiredPosition;

    void LateUpdate()
    {
        if (target == null)
        {
            Debug.LogWarning("Target (player) not set for CameraFollow script.");
            return;
        }

        // Calculate the desired position for the camera
        desiredPosition = target.position + target.TransformDirection(offset);

        // Interpolate between the current position and the desired position for smooth camera movement
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed * Time.deltaTime);
        transform.position = smoothedPosition;

        // Rotate the camera to match the player's rotation
        Quaternion desiredRotation = Quaternion.LookRotation(target.position - transform.position, target.up);
        transform.rotation = Quaternion.Slerp(transform.rotation, desiredRotation, rotationSpeed * Time.deltaTime);


    }
}