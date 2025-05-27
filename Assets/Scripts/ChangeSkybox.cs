using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeSkybox : MonoBehaviour
{
    public Material day;
    public Material sunset;

    public void Daytime()
    {
        RenderSettings.skybox = day;
    }

    public void Sunset()
    {
        RenderSettings.skybox = sunset;
    }
}
