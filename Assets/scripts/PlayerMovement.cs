using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 2f; // Adjust this value to set the player's movement speed.
    private Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        // Get the Rigidbody component attached to the GameObject
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal"); // Get horizontal input (left and right arrow keys)
        float verticalInput = Input.GetAxis("Vertical"); // Get vertical input (up and down arrow keys)

        // Calculate the movement direction
        Vector3 movement = new Vector3(horizontalInput, 0f, verticalInput).normalized;

        // Apply the movement to the rigidbody's velocity, allowing movement in all directions
        rb.velocity = movement * moveSpeed;

        // Optionally, you can add vertical movement using the same input setup (for example, space and control keys)
        float verticalMovement = Input.GetAxis("Jump") - Input.GetAxis("Crouch");
        Vector3 verticalVelocity = new Vector3(0f, verticalMovement, 0f).normalized * moveSpeed;

        // Apply vertical movement to the rigidbody's velocity
        rb.velocity += verticalVelocity;
    }
}
