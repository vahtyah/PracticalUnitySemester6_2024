using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 5.0f;
    public float jumpForce = 7.0f;
    public LayerMask groundMask;
    public Transform groundCheck;
    private float movementX;
    private float movementZ;
    private Rigidbody rb;
    private bool isGrounded;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        movementX = Input.GetAxis("Horizontal") * speed;
        movementZ = Input.GetAxis("Vertical") * speed;

        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
        }

        isGrounded = Physics.CheckSphere(groundCheck.position, .2f, groundMask);
    }

    void FixedUpdate()
    {
        Vector3 movement = transform.right * movementX + transform.forward * movementZ;
        rb.MovePosition(transform.position + movement * Time.fixedDeltaTime);
    }
}