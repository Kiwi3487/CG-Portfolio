using UnityEngine;

public class CameraSwitcher : MonoBehaviour
{
    public Camera camera1;
    public Camera camera2;

    private Camera activeCamera;

    void Start()
    {
        activeCamera = camera1;
        camera1.enabled = true;
        camera2.enabled = false;
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            activeCamera.enabled = false;
            activeCamera = (activeCamera == camera1) ? camera2 : camera1;
            activeCamera.enabled = true;
        }
    }
}