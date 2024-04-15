using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MainMenu : MonoBehaviour
{
    public GameObject mainMenu;
    public GameObject settingsMenu;
    public GameObject creditsMenu;
    public GameObject levelSelector;

    private void Awake()
    {
        Time.timeScale = 1.0f;
    }

    //AudioSource source;
    public void PlayGame()
    {
        mainMenu.SetActive(false);
        levelSelector.SetActive(true);
    }

    public void OptionsButton()
    {
        mainMenu.SetActive(false);
        settingsMenu.SetActive(true);
    }

    public void CreditsButton()
    {
        mainMenu.SetActive(false);
        creditsMenu.SetActive(true);
    }


    public void BackOptions()
    {
        settingsMenu.SetActive(false);
        mainMenu.SetActive(true);
    }

    public void BackCredits()
    {
        creditsMenu.SetActive(false);
        mainMenu.SetActive(true);
    }

    public void BackLevelSelector()
    {
        levelSelector.SetActive(false);
        mainMenu.SetActive(true);
    }


    public void PlayItaly()
    {
        SceneManager.LoadSceneAsync("Italy Scene");
    }

    public void PlayJapan()
    {
        SceneManager.LoadSceneAsync("Japan Scene");
    }

    public void PlayPortugal()
    {
        SceneManager.LoadSceneAsync("Portugal Scene");
    }

    public void PlayMexico()
    {
        SceneManager.LoadSceneAsync("México Scene");
    }

    public void PlayBrasil()
    {
        SceneManager.LoadSceneAsync("Brazil Scene");
    }

    public void PlaySpain()
    {
        SceneManager.LoadSceneAsync("Spain Scene");
    }

}
    