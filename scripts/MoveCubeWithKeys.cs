using UnityEngine;

public class MoveCubeWithKeys : MonoBehaviour
{
    public float speed;

    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        transform.Translate(
            horizontal * speed * Time.deltaTime,
            vertical * speed * Time.deltaTime,
            0
        );
    }
}