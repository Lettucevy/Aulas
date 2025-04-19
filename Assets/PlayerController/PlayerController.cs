using UnityEngine;
using UnityEngine.EventSystems;

public class PlayerController : MonoBehaviour
{
    [Header("Player Movement")]
    public float moveSpeed = 5f;

    private Vector2 currentInput;
    private Vector3 moveDirection;
    private Rigidbody rb;

    public Transform orientation;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    private void FixedUpdate()
    {        
        currentInput.x = Input.GetAxis("Horizontal");
        currentInput.y = Input.GetAxis("Vertical");
        currentInput.Normalize();
        moveDirection = orientation.forward * currentInput.y + currentInput.x * orientation.right;
        rb.MovePosition(rb.position + moveDirection * moveSpeed * Time.fixedDeltaTime);
    }
}
