using UnityEngine;

public class MoveObject : MonoBehaviour
{
  public Vector3 displacement;
  private Vector3 originalPosition;

  void Start()
  {
    originalPosition = transform.position;
  }

  void Update()
  {
    if (Input.GetAxis("Jump") > 0)
    {
      transform.position = originalPosition + displacement;
    }
  }
}