using UnityEngine;

public class CameraSwitcher : MonoBehaviour
{
    public Camera camera1;
    public Camera camera2;

    private GameObject activeCameraObj;

    void Start()
    {
        activeCameraObj = camera1.gameObject;
        camera1.gameObject.SetActive(true);
        camera2.gameObject.SetActive(false);
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            activeCameraObj.SetActive(false);
            activeCameraObj = (activeCameraObj == camera1.gameObject) ? camera2.gameObject : camera1.gameObject;
            activeCameraObj.SetActive(true);
        }
    }
}