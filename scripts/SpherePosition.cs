using UnityEngine;

public class SpherePosition : MonoBehaviour
{
  void OnGUI()
  {
    GUIStyle style = new GUIStyle();
    style.fontSize = 100;

    GUI.Label(
      new Rect(10, 10, 600, 50),
      "Position: " + transform.position,
      style
    );
  }
}