using UnityEngine;

public class MoveForward : MonoBehaviour
{
    public float speed;
    public float rotationSpeed;

    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");

        transform.Rotate(
            0,
            horizontal * rotationSpeed * Time.deltaTime,
            0
        );

        transform.Translate(
            transform.forward * speed * Time.deltaTime,
            Space.World
        );

        Debug.DrawRay(
            transform.position,
            transform.forward * 3,
            Color.red
        );
    }
}