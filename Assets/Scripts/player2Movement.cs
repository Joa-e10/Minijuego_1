using UnityEngine;

public class player2Movement : MonoBehaviour
{
    public int speed;
    private Rigidbody2D _rb;
    private Vector2 _movementInput;
    private float _direccionX;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        _movementInput.x = Input.GetAxisRaw("Horizontal");
        _movementInput.y = Input.GetAxisRaw("Vertical");

        _movementInput = _movementInput.normalized;
    }

    private void FixedUpdate()
    {
        _rb.linearVelocity = _movementInput * speed;
    }
}
