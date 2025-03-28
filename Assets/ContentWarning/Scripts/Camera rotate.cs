using UnityEngine;

public class CameraOrbit : MonoBehaviour
{
    public Transform target;
    public float radius = 10f;
    public float speed = 10f;
    public float height = 5f; 
    private float angle = 0f;

    void Update()
    {
        if (target == null) return;
        angle += speed * Time.deltaTime;
        float radians = angle * Mathf.Deg2Rad;
        float x = target.position.x + Mathf.Cos(radians) * radius;
        float z = target.position.z + Mathf.Sin(radians) * radius;
        float y = target.position.y + height;

        transform.position = new Vector3(x, y, z);
        transform.LookAt(target);
    }
}
