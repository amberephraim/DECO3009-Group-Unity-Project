using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FocusCameras : MonoBehaviour
{
    public Camera[] cams;
    private int camNum;
    void Start()
    {
        camNum = 0;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.M)) //cycle through cams in scene
        {
            camNum = (camNum + 1) % cams.Length;
            for (int i = 0; i < cams.Length; i++)
            {
                cams[i].enabled = false;
            }
            cams[camNum].enabled = true;
        }
    }
}
