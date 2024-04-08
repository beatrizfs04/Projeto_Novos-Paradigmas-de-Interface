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

    // Start is called before the first frame update
    public void PlayGame()
    {
        Debug.Log("Level Selector");
        Debug.Log("Level Selector");
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


}
    