using UnityEngine;

public class PlayerOneRacketMovement : MonoBehaviour
{
    public float speed = 5.0f;
    

    // Update is called once per frame
    void Update()
    {
        float verticalInput = Input.GetAxis("");
        transform.Translate(Vector3.up * (verticalInput * speed * Time.deltaTime));
    }
}
