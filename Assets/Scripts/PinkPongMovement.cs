using UnityEngine;

public class PingPongMovement : MonoBehaviour
{
    [SerializeField] private float speed = 3f;
    [SerializeField] private float distance = 5f;

    private Vector3 startPosition;

    void Start()
    {
        // Save the starting position of the object
        startPosition = transform.position;
    }

    void Update()
    {
        // Calculate the ping-pong offset value
        float offset = Mathf.PingPong(Time.time * speed, distance);

        // Move along the X-axis (Change to .y or .z to move on other axes)
        transform.position = new Vector3(startPosition.x + offset, startPosition.y, startPosition.z);
    }
}
