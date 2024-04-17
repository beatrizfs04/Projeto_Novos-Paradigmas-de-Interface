using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class audio_play : MonoBehaviour
{
    public AudioSource selectSource;
    public AudioSource musicSource;

    public void SelectMenuSFX()
    {
        selectSource.Play();
    }

    public void PauseLevelMusic()
    {
        musicSource.Pause();
    }

    public void ResumeLevelMusic()
    {
        musicSource.Play();
    }

}
