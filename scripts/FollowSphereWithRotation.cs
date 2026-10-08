using UnityEngine;

public class FollowSphereWithRotation : MonoBehaviour
{
    public float speed;
    public Transform target;

    void Update()
    {
        transform.LookAt(target);

        Vector3 direction = target.position - transform.position;
        direction = direction.normalized;

        transform.Translate(direction * speed * Time.deltaTime, Space.World);
    }
}