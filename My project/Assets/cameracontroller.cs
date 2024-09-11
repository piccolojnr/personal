using UnityEngine;

public class cameracontroller : MonoBehaviour
{
    public Transform player;    // The player's transform to follow
    private Vector3 offset;      // Offset distance between the player and camera
    public float smoothSpeed = 0.125f;

    void Start()
    {

        // ofset is the difference between the player's position and the camera's position
        offset = transform.position - player.position;

    }

    void LateUpdate()
    {
        // Desired position of the camera
        Vector3 desiredPosition = player.position + offset;

        // Smoothly interpolate between the current camera position and the desired position
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);

        // Set the camera's position to the smoothed position
        transform.position = smoothedPosition;

        // Optionally, you can make the camera look at the player
        transform.LookAt(player);
    }
}
