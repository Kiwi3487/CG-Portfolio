using UnityEngine;

public class ObjectMove : MonoBehaviour
{
    public float distance = 3f;
    private float start;
    private int direction = 1;

    void Start()
    {
        start = transform.position.x;
    }

    void Update()
    {
        transform.position += Vector3.right * (direction * 2 * Time.deltaTime);
        if (Mathf.Abs(transform.position.x - start) >= distance)
        {
            direction *= -1;
        }
    }
}