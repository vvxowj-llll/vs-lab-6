using UnityEngine;

public class Box : MonoBehaviour
{
    private Rigidbody2D rb;

    public float gravityScale = 1f;
    public float pushForce = 5f;
    
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.gravityScale = gravityScale;
        rb.mass = 1f;
        rb.drag = 0.5f;
        rb.angularDrag = 0.5f;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.K))
        {
            KickBox();
        }
    }

    void KickBox()
    {
        rb.AddForce(new Vector2(2f, 5f), ForceMode2D.Impulse);
    }

    public void Push(Vector2 direction, float force)
    {
        rb.AddForce(direction * force, ForceMode2D.Impulse);
    }
}