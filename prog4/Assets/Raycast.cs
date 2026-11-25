
using UnityEngine;

public class Raycast : MonoBehaviour
{
    void Update()
    {
        Ray ray = Camera.main.ScreenPointToRay(
            new Vector3(Screen.width / 2, Screen.height / 2, 0));

        RaycastHit hit;

        if (Physics.Raycast(ray, out hit))
        {
            // Draw ray only up to the Cube
            Debug.DrawLine(ray.origin, hit.point, Color.red);

            Debug.Log("Target Found: " + hit.collider.name);
            Debug.Log("Distance: " + hit.distance);
            Debug.Log("Position: " + hit.point);

            hit.collider.GetComponent<Renderer>().material.color = Color.green;
        }
    }
}
