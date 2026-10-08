using UnityEngine;

public class MoveCube : MonoBehaviour
{
  public Vector3 moveDirection;
  public float speed;

  void Update()
  {
    transform.Translate(
      moveDirection.x * speed * Time.deltaTime,
      moveDirection.y * speed * Time.deltaTime,
      moveDirection.z * speed * Time.deltaTime
    );
  }
}