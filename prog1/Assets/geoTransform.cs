
using UnityEngine;

public class geoTransform : MonoBehaviour
{
    public float moveSpeed = 5f;
    public float rotateSpeed = 100f;
    public float scaleSpeed = 2f;

    void Update()
    {
        // Movement
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        transform.Translate(x * moveSpeed * Time.deltaTime, 0,
                            z * moveSpeed * Time.deltaTime, Space.World);

        // Up and Down movement
        if (Input.GetKey(KeyCode.R))
            transform.Translate(Vector3.up * moveSpeed * Time.deltaTime);

        if (Input.GetKey(KeyCode.F))
            transform.Translate(Vector3.down * moveSpeed * Time.deltaTime);

        // Rotation
        if (Input.GetKey(KeyCode.J))
            transform.Rotate(Vector3.up * rotateSpeed * Time.deltaTime);

        if (Input.GetKey(KeyCode.L))
            transform.Rotate(Vector3.down * rotateSpeed * Time.deltaTime);

        if (Input.GetKey(KeyCode.I))
            transform.Rotate(Vector3.right * rotateSpeed * Time.deltaTime);

        if (Input.GetKey(KeyCode.K))
            transform.Rotate(Vector3.left * rotateSpeed * Time.deltaTime);

        // Scaling
        if (Input.GetKey(KeyCode.Equals))
            transform.localScale += Vector3.one * scaleSpeed * Time.deltaTime;

        if (Input.GetKey(KeyCode.Minus))
            transform.localScale = Vector3.Max(
                Vector3.one * 0.2f,
                transform.localScale - Vector3.one * scaleSpeed * Time.deltaTime
            );
    }
}
