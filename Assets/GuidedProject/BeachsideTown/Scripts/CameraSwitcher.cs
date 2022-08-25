using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSwitcher : MonoBehaviour
{
    public Camera wideCam;
    public Camera closeCam;
    public Camera midCam;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp("1"))
        {
            WideCam();
        }
        if (Input.GetKeyUp("2"))
        {
            MidCam();
        }
        if (Input.GetKeyUp("3"))
        {
            CloseCam();
        }
    }

    public void CloseCam()
    {
        closeCam.enabled = true;
        wideCam.enabled = false;
        midCam.enabled = false;
    }

    public void WideCam()
    {
        wideCam.enabled = true;
        closeCam.enabled = false;
        midCam.enabled = false;
    }

    public void MidCam()
    {
        wideCam.enabled = false;
        closeCam.enabled = false;
        midCam.enabled = true;
    }
}

