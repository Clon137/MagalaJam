using UnityEngine;

public class BubbleControl : MonoBehaviour
{
    Rigidbody2D rb;

    public int jump = 5;
    [SerializeField] SpriteRenderer sprite;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
            {
                rb.linearVelocity = new Vector2(rb.linearVelocityX, rb.linearVelocityY * jump);
            }
    }
}
