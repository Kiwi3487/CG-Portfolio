using UnityEngine;

public class CameraSwitcher : MonoBehaviour
{
    public Camera camera1;
    public Camera camera2;
    public Camera camera3;

    private GameObject[] cameras;
    private int activeIndex = 0;

    void Start()
    {
        cameras = new GameObject[] { camera1.gameObject, camera2.gameObject, camera3.gameObject };
        for (int i = 0; i < cameras.Length; i++)
        {
            cameras[i].SetActive(i == activeIndex);
        }
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            cameras[activeIndex].SetActive(false);
            activeIndex = (activeIndex + 1) % cameras.Length;
            cameras[activeIndex].SetActive(true);
        }
    }
}