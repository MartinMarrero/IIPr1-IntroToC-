using UnityEngine;

public class DistanceFrom : MonoBehaviour
{
    private GameObject sphere;
    private GameObject cube;
    private GameObject cylinder;

    private Vector3 lastSpherePosition;
    private Vector3 lastCubePosition;
    private Vector3 lastCylinderPosition;

    void Start()
    {
        sphere = GameObject.FindWithTag("Sphere");
        cube = GameObject.FindWithTag("Cube");
        cylinder = GameObject.FindWithTag("Cylinder");

        if (sphere == null || cube == null || cylinder == null)
        {
            Debug.LogError("Could not find one or more objects. Check their tags.");
            return;
        }

        UpdateDistances();

        lastSpherePosition = sphere.transform.position;
        lastCubePosition = cube.transform.position;
        lastCylinderPosition = cylinder.transform.position;
    }

    void Update()
    {
        if (sphere == null || cube == null || cylinder == null)
            return;

        if (sphere.transform.position != lastSpherePosition ||
            cube.transform.position != lastCubePosition ||
            cylinder.transform.position != lastCylinderPosition)
        {
            UpdateDistances();

            lastSpherePosition = sphere.transform.position;
            lastCubePosition = cube.transform.position;
            lastCylinderPosition = cylinder.transform.position;
        }
    }

    void UpdateDistances()
    {
        float cubeDistance = Vector3.Distance(
            sphere.transform.position,
            cube.transform.position
        );

        float cylinderDistance = Vector3.Distance(
            sphere.transform.position,
            cylinder.transform.position
        );

        Debug.Log("Distance to the cube: " + cubeDistance);
        Debug.Log("Distance to the cylinder: " + cylinderDistance);
    }
}