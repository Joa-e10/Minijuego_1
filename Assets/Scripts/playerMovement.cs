using UnityEngine;

public class playerMovement : MonoBehaviour
{
    public float speed;
    private float _horizontalDireccion;
    private Rigidbody2D _rb;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //_rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        _horizontalDireccion = Input.GetAxisRaw("Horizontal");
        transform.position = new Vector2(transform.position.x + _horizontalDireccion * speed * Time.deltaTime, transform.position.y);
        //_rb.linearVelocityX = _horizontalDireccion * speed;
    }
}
