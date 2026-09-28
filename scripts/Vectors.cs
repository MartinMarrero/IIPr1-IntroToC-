using UnityEngine;

public class Vectors : MonoBehaviour
{
  public Vector3 vector1;
  public Vector3 vector2;

  public float magnitude1;
  public float magnitude2;
  public float angle;
  public float distance;
  public string highestVector;

  void Update()
  {
    magnitude1 = vector1.magnitude;
    magnitude2 = vector2.magnitude;

    angle = Vector3.Angle(vector1, vector2);
    distance = Vector3.Distance(vector1, vector2);

    if (vector1.y > vector2.y)
    {
      highestVector = "Vector 1";
    }
    else if (vector2.y > vector1.y)
    {
      highestVector = "Vector 2";
    }
    else
    {
      highestVector = "Same height";
    }
    Debug.Log("Vector 1 Magnitude: " + magnitude1);
    Debug.Log("Vector 2 Magnitude: " + magnitude2);
    Debug.Log("Angle: " + angle);
    Debug.Log("Distance: " + distance);
    Debug.Log("Highest vector: " + highestVector);
  }
};