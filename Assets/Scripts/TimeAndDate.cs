using System.Collections;
using System.Collections.Generic;
using System;
using System.Globalization;
using UnityEngine;
using TMPro;

public class TimeAndDate : MonoBehaviour
{
    public TMP_Text timeAndDate;

    void Start()
    {

    }
    // Update is called once per frame
    void Update()
    {
        timeAndDate.text = DateTime.Now.ToString();
    }
}
