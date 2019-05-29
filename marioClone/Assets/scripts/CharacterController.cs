using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController : MonoBehaviour
{
    [SerializeField, Tooltip("Max speed, in units per second, that the character moves.")]
    public float speed = 9;

    [SerializeField, Tooltip("Acceleration while grounded.")]
    public float walkAcceleration = 75;

    [SerializeField, Tooltip("Acceleration while in the air.")]
    public float airAcceleration = 30;

    [SerializeField, Tooltip("Deceleration applied when character is grounded and not attempting to move.")]
    public float groundDeceleration = 70;

    [SerializeField, Tooltip("Max height the character will jump regardless of gravity")]
    public float jumpHeight = 4;

    private BoxCollider2D boxCollider;

    private Vector2 velocity;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Jump"))
        {
            velocity.y = Mathf.Sqrt(2 * jumpHeight * Mathf.Abs(Physics2D.gravity.y));
        }
        movement();
    }

    void movement()
    {
        float moveInput = Input.GetAxisRaw("Horizontal");

        transform.Translate(velocity * Time.deltaTime);

        velocity.x = Mathf.MoveTowards(velocity.x, speed * moveInput, walkAcceleration * Time.deltaTime);

        

    }
}
