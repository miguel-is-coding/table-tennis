using UnityEngine;

public class PlayerTwoRacketMovement : MonoBehaviour
{
    public float speed = 5.0f;
    

    // Update is called once per frame
    void Update()
    {
        float verticalInput = Input.GetAxis("Vertical");
        transform.Translate(Vector3.up * (verticalInput * speed * Time.deltaTime));
    }
}
