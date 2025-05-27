using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayPianoKeys : MonoBehaviour
{
    public AudioSource note;
    public float pitch = 0;
    private Animator anim;

    void Start()
    {
        anim = GetComponent<Animator>();
        anim.ResetTrigger("pressed");
    }

    void OnMouseDown()
    {
        anim.ResetTrigger("pressed");
        anim.SetTrigger("pressed");
        try
        {
            note.pitch = pitch;
            note.Play();
        }
        catch
        {
            Debug.Log("no audio source found");
        }
    }

}
