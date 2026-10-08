using UnityEngine;

public class CubeSpeed : MonoBehaviour
{
  public float speed;

  void Update()
  {
    if (Input.GetKey(KeyCode.UpArrow))
    {
      float result = speed * Input.GetAxis("Vertical");
      Debug.Log("Up: " + result);
    }

    if (Input.GetKey(KeyCode.DownArrow))
    {
      float result = speed * Input.GetAxis("Vertical");
      Debug.Log("Down: " + result);
    }

    if (Input.GetKey(KeyCode.RightArrow))
    {
      float result = speed * Input.GetAxis("Horizontal");
      Debug.Log("Right: " + result);
    }

    if (Input.GetKey(KeyCode.LeftArrow))
    {
      float result = speed * Input.GetAxis("Horizontal");
      Debug.Log("Left: " + result);
    }
  }
}