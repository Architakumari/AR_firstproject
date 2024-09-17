using UnityEngine;

public class CubeMover : MonoBehaviour
{
    public float moveSpeed = 5f;

    void Update()
    {
        float moveX = Input.GetAxis("Horizontal") * moveSpeed * Time.deltaTime;
        float moveZ = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;

        // Move the cube along the X and Z axes based on input
        transform.Translate(moveX, 0, moveZ);
    }
}