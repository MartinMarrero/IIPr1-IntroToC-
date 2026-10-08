using UnityEngine;

public class FollowSphere : MonoBehaviour
{
    public float speed;
    public Transform target;

    void Update()
    {
        Vector3 direction = target.position - transform.position;

        direction.y = 0;
        direction = direction.normalized;

        transform.Translate(direction * speed * Time.deltaTime, Space.World);
    }
}