using UnityEngine;

public class RotateCamera : MonoBehaviour
{
    public Transform player; // Reference to the player's transform

    // Update is called once per frame
    void Update()
    {
        if (player == null)
        {
            Debug.LogWarning("Player transform not assigned!");
            return;
        }

        // Make the camera look at the player
        transform.LookAt(player.position);
    }
}
