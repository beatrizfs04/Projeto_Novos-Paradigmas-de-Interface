using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class audio_play : MonoBehaviour
{
    public AudioSource selectSource;

    public void SelectMenuSFX()
    {
        selectSource.Play();
    }
}
