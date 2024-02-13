using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 5.0f;
    public float jumpForce = 7.0f;
    private float movementX;
    private float movementZ;
    private Rigidbody rb;
    [SerializeField] private bool isGrounded;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        // Обработка ввода для движения
        movementX = Input.GetAxis("Horizontal") * speed;
        movementZ = Input.GetAxis("Vertical") * speed;

        // Проверка нажатия клавиши прыжка и условия нахождения на земле
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            Debug.Log("CCgi");
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
        }
    }

    void FixedUpdate()
    {
        // Применение движения
        Vector3 movement = transform.right * movementX + transform.forward * movementZ;
        rb.MovePosition(transform.position + movement * Time.fixedDeltaTime);
    }

    void OnCollisionEnter(Collision other)
    {
        // Проверка столкновения с землей
        if (other.gameObject.CompareTag("Ground"))
        {
            isGrounded = true;
        }
    }

    void OnCollisionExit(Collision other)
    {
        // Проверка выхода из столкновения с землей
        if (other.gameObject.CompareTag("Ground"))
        {
            isGrounded = false;
        }
    }
}