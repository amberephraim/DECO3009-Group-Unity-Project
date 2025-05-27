using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenUI : MonoBehaviour
{
    bool open;
    CanvasGroup canvasGroup;

    void Start()
    {
        open = false;
        canvasGroup = GetComponent<CanvasGroup>();
        canvasGroup.alpha = 0;
        this.gameObject.transform.GetChild(0).gameObject.SetActive(false);
        this.gameObject.transform.GetChild(1).gameObject.SetActive(false);
        this.gameObject.transform.GetChild(2).gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.B)) // Update to buttons on VR controller
        {
            if (!open)
            {
                canvasGroup.alpha = 1.0f;
                canvasGroup.interactable = true;
                this.gameObject.transform.GetChild(0).gameObject.SetActive(true);
                //playerController.GetComponent<FirstPersonController>().SetActive(false);
                open = true;
            }
            else
            {
                canvasGroup.alpha = 0.0f;
                canvasGroup.interactable = false;
                this.gameObject.transform.GetChild(0).gameObject.SetActive(false);
                this.gameObject.transform.GetChild(1).gameObject.SetActive(false);
                this.gameObject.transform.GetChild(2).gameObject.SetActive(false);
                //playerController.GetComponent<FirstPersonController>().SetActive(true);
                open = false;
            }
        }
    }
}
