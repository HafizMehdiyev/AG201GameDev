using Cinemachine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;
public class CameraManager : MonoBehaviour
{
    [SerializeField] CinemachineVirtualCamera yaxinCam;
    [SerializeField] CinemachineVirtualCamera uzaqCam;

    private bool _yaxincam = false;


    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            SwitchCamera();
        }
    }

    public void SwitchCamera()
    {
        _yaxincam = !_yaxincam;
        if (_yaxincam)
        {
            yaxinCam.Priority = 20;
            uzaqCam.Priority = 10;
        }
        else
        {
            yaxinCam.Priority = 10;
            uzaqCam.Priority = 20;
        }
    }

}
