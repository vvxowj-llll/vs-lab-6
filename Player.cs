using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 5f;
    public float jumpForce = 7f;
    private Rigidbody2D rb;
    private bool isGrounded = false;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        float moveInput = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(moveInput * moveSpeed, rb.velocity.y);

        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpForce);
        }

        if (Input.GetKeyDown(KeyCode.K))
        {
            KickBox();
        }
    }

    void KickBox()
    {
        Collider2D[] boxes = Physics2D.OverlapCircleAll(transform.position, 1f);
        foreach (var box in boxes)
        {
            if (box.CompareTag("Box"))
            {
                Rigidbody2D boxRb = box.GetComponent<Rigidbody2D>();
                if (boxRb != null) boxRb.AddForce(Vector2.right * 5f, ForceMode2D.Impulse);
            }
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground")  collision.gameObject.CompareTag("Box")) isGrounded = true;
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground")  collision.gameObject.CompareTag("Box")) isGrounded = false;
    }
}