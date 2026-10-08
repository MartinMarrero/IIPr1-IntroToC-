using UnityEngine;

public class MoveSphereWithKeysFix : MonoBehaviour
{
    public float speed;

    void Update()
    {
        float horizontal = 0;
        float vertical = 0;

        if (Input.GetKey(KeyCode.A))
        {
            horizontal = -1;
        }

        if (Input.GetKey(KeyCode.D))
        {
            horizontal = 1;
        }

        if (Input.GetKey(KeyCode.W))
        {
            vertical = 1;
        }

        if (Input.GetKey(KeyCode.S))
        {
            vertical = -1;
        }

        transform.Translate(
            horizontal * speed * Time.deltaTime,
            vertical * speed * Time.deltaTime,
            0
        );
    }
}