using UnityEngine;

public class Ball : MonoBehaviour
{
    public float speed = 5.0f;
    public float speedIncrement = 0.01f;
    public Color[] colors;
    private Rigidbody2D _rigidbody;
    private SpriteRenderer _spriteRenderer;

    void Start()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
        int direction = Random.Range(0, 2) * 2 - 1;
        _rigidbody.velocity = new Vector2(speed * direction, 0);
        _spriteRenderer = GetComponent<SpriteRenderer>();
    }
    
    void OnCollisionEnter2D(Collision2D collision)
    {
        // Change color on collision
        if (colors.Length > 0)
        {
            _spriteRenderer.color = colors[Random.Range(0, colors.Length)];
        }

        // Increase speed on collision
        _rigidbody.velocity *= speedIncrement;
    }
}
