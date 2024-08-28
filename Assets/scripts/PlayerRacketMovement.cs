using UnityEngine;

public class PlayerRacketMovement : MonoBehaviour
{
    public float speed = 5.0f;
    public string playerAxis = "VerticalWSKeys";
    private Rigidbody2D _rigidbody;

    void Start()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        var direction = Input.GetAxis(playerAxis);
        var moveSpeed = speed * direction;
        _rigidbody.velocity = new Vector2(0, moveSpeed);
    }
}