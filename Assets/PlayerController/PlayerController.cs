using UnityEngine;

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
    private void Update()
    {
        currentInput.x = Input.GetAxis("Horizontal");
        currentInput.y = Input.GetAxis("Vertical");
        currentInput.Normalize();
        moveDirection = (orientation.forward * currentInput.y + currentInput.x * orientation.right) * moveSpeed;
    }
    private void FixedUpdate()
    {
        rb.AddForce(moveDirection * 1000, ForceMode.Force);
    }

}
