using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UserInformation : MonoBehaviour
{
    public Text cameraText;
    public Text cameraSpeed;
    public Text cameraOriginalPosition;
    public Transform target;
    //public SwitchCameras switchcameras;

    private Vector3[] originalCamerasPosition;
    private Vector3 lastPosition;
    private Camera[] Cameras;
    private int cameraIndex = 0;

    // Use this for initialization
    void Start()
    {
       // Cameras = switchcameras.cameras;
        if (Cameras.Length > 0)
        {
            originalCamerasPosition = new Vector3[Cameras.Length];
            for (int i = 0; i < Cameras.Length; i++)
            {
                originalCamerasPosition[i] = Cameras[i].transform.position;
            }
        }
    }
    // Update is called once per frame
    void Update()
    {
        if (cameraIndex == Cameras.Length)
            cameraIndex = 0;

        if (Cameras[cameraIndex].enabled == true)
        {
            cameraText.text = Cameras[cameraIndex].name;
            float camSpeed = (Cameras[cameraIndex].transform.position - lastPosition).magnitude / Time.deltaTime;
            cameraSpeed.text = camSpeed.ToString();
            lastPosition = Cameras[cameraIndex].transform.position;
            cameraOriginalPosition.text = originalCamerasPosition[cameraIndex].ToString();
        }
        else
        {
            cameraIndex++;
        }
    }
}