using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class EnemyPatrol : MonoBehaviour
{
    [SerializeField] private float speed = 2f;
    [SerializeField] private float leftX = -3f;   // Left boundary
    [SerializeField] private float rightX = 3f;   // Right boundary

    private Rigidbody2D rb;
    private int direction = 1; // 1 = moving right, -1 = moving left

    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        // Move the enemy
        rb.linearVelocity = new Vector2(direction * speed, rb.linearVelocity.y);

        // Check boundaries
        if (transform.position.x >= rightX)
        {
            direction = -1; // move left
        }
        else if (transform.position.x <= leftX)
        {
            direction = 1; // move right
        }
    }
}
