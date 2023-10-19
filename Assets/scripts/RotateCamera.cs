using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public Transform player; // Reference to the player's transform
    public Vector3 offset = new Vector3(1.5f, 2f, -3f); // Offset to position the camera relative to the player
    public float rotationspeed;


    // Update is called once per frame
    void Update()
    {
        if (player == null)
        {
            Debug.LogWarning("Player transform not assigned!");
            return;
        }

        // Calculate the desired position based on player's position and offset
        Vector3 desiredPosition = player.position + offset;

        // Smoothly move the camera to the desired position
        transform.position = Vector3.Lerp(transform.position, desiredPosition, Time.deltaTime * 5f);

        // Make the camera look at the player
        transform.LookAt(player.position);

        float horizontalInput = Input.GetAxis("Horizontal");
        transform.Rotate(Vector3.up, horizontalInput * rotationspeed * Time.deltaTime);
    }
}
