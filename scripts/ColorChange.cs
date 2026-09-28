using UnityEngine;

public class ColorChange : MonoBehaviour
{
  public int waitFrames = 120;

  private Color color;
  private int counter;

  void Start() {
    color = new Color(
      Random.Range(0.0f, 1.0f),
      Random.Range(0.0f, 1.0f),
      Random.Range(0.0f, 1.0f)
    );
    GetComponent<Renderer>().material.color = color;
  }

  void Update() {
    counter++;
    if(counter >= waitFrames) {
       int position = Random.Range(0, 3);
        float value = Random.Range(0.0f, 1.0f);

        if (position == 0)
            color.r = value;
        else if (position == 1)
            color.g = value;
        else
            color.b = value;

        GetComponent<Renderer>().material.color = color;

        counter = 0;
    }
  }
}
