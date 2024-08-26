using UnityEngine;

public class PlayerOneRacketMovement : MonoBehaviour
{
    public float speed = 5.0f;
    public string playerAxis = "VerticalWSKeys";
    
    // Update is called once per frame
    void Update()
    {
        var direction = Input.GetAxis(playerAxis);
        var moveSpeed = speed * Time.deltaTime;
        transform.Translate(Vector3.up * (direction * moveSpeed));
    }
}
