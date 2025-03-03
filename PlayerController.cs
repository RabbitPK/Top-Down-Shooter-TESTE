using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 5f;
    private Rigidbody2D rb;
    private Vector2 moveInput;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        // Captura o input do teclado (WASD ou setas)
        moveInput.x = Input.GetAxisRaw("Horizontal");
        moveInput.y = Input.GetAxisRaw("Vertical");
        moveInput.Normalize(); // Evita que a velocidade seja maior ao andar na diagonal
    }

    void FixedUpdate()
    {
        // Move o player com base no input capturado
        rb.linearVelocity = moveInput * moveSpeed;
    }
}
