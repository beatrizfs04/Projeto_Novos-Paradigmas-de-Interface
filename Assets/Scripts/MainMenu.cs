using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MainMenu : MonoBehaviour
{
    // Start is called before the first frame update
    public AudioClip selectAudio;
    //AudioSource source;
    public void PlayGame()
    {
        //source = GetComponent<AudioSource>();
        //source.clip = selectAudio;
        //source.Play();
        
        SceneManager.LoadSceneAsync("Level 1");
    }

    public void OptionsButton()
    {
        //SceneManager.LoadSceneAsync("Level 1");
    }

    public void CreditsButton()
    {
        //SceneManager.LoadSceneAsync("Level 1");
    }


}
    