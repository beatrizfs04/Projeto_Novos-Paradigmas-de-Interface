using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class PauseManager : MonoBehaviour
{
    [Tooltip("Key for pausing the game")]

    [SerializeField] GameObject pauseGameObject;
    [SerializeField] GameObject finishGameObject;

    int score = 0;

    CanvasRenderer canvasRendererImage;
    CanvasRenderer canvasRendererButton1;
    CanvasRenderer canvasRendererButton2;

    bool isPaused = false;

    bool isFinish = false;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Cancel"))
        {

            if(isPaused)
            {
                Time.timeScale = 1.0f;
                isPaused = false;
                if(pauseGameObject.activeSelf)
                {
                    canvasRendererImage = null;
                    canvasRendererButton1 = null;
                    canvasRendererButton2 = null;
                    pauseGameObject.SetActive(false);
                }
                gameObject.GetComponent<audio_play>().ResumeLevelMusic();

            } else {
                EventSystem.current.SetSelectedGameObject(pauseGameObject.transform.Find("Canvas").Find("Resume").gameObject, new BaseEventData(EventSystem.current));
                isPaused = true;
                Time.timeScale = 0.0f;
                if (!pauseGameObject.activeSelf)
                {
                    pauseGameObject.SetActive(true);
                    canvasRendererImage = pauseGameObject.transform.Find("Canvas").Find("Image").GetComponent<CanvasRenderer>();
                    canvasRendererButton1 = pauseGameObject.transform.Find("Canvas").Find("Back").GetComponent<CanvasRenderer>();
                    canvasRendererButton2 = pauseGameObject.transform.Find("Canvas").Find("Resume").GetComponent<CanvasRenderer>();
                    canvasRendererImage.SetAlpha(0.0f);
                    canvasRendererButton1.SetAlpha(0.0f);
                    canvasRendererButton2.SetAlpha(0.0f);
                }
                gameObject.GetComponent<audio_play>().PauseLevelMusic();

            }
        }

        if(Input.GetKeyDown(KeyCode.Return) && isFinish)
        {
            SceneManager.LoadSceneAsync("MainMenu");
            GameObject StatusHandler = GameObject.Find("StatusHandler");
            if (StatusHandler) StatusHandler.GetComponent<InstructionsScript>().OpenLevelSelector();
        }


        if (isPaused)
        {

            if (canvasRendererImage && canvasRendererImage.GetAlpha() < 1.0f) canvasRendererImage.SetAlpha(canvasRendererImage.GetAlpha() + 0.01f);
            if (canvasRendererButton1 && canvasRendererButton1.GetAlpha() < 1.0f) canvasRendererButton1.SetAlpha(canvasRendererButton1.GetAlpha() + 0.01f);
            if (canvasRendererButton2 && canvasRendererButton2.GetAlpha() < 1.0f) canvasRendererButton2.SetAlpha(canvasRendererButton2.GetAlpha() + 0.01f);
        }
        else
        {
            if (canvasRendererImage && canvasRendererImage.GetAlpha() > 0.0f) canvasRendererImage.SetAlpha(canvasRendererImage.GetAlpha() - 0.01f);
            if (canvasRendererButton1 && canvasRendererButton1.GetAlpha() > 0.0f) canvasRendererButton1.SetAlpha(canvasRendererButton1.GetAlpha() - 0.01f);
            if (canvasRendererButton1 && canvasRendererButton1.GetAlpha() > 0.0f) canvasRendererButton1.SetAlpha(canvasRendererButton1.GetAlpha() - 0.01f);
        }

    }

 

    public void Resume()
    {
        canvasRendererImage.SetAlpha(0.0f);
        canvasRendererButton1.SetAlpha(0.0f);
        canvasRendererButton2.SetAlpha(0.0f);
        isPaused = false;
        Time.timeScale = 1.0f;
        gameObject.GetComponent<audio_play>().ResumeLevelMusic();
    }

    public void BackToMenu()
    {
        SceneManager.LoadSceneAsync("MainMenu");
        GameObject StatusHandler = GameObject.Find("StatusHandler");
        if (StatusHandler) StatusHandler.GetComponent<InstructionsScript>().OpenLevelSelector();
    }

    public void FinishGame()
    {
        isFinish = true;
        finishGameObject.SetActive(true);
        Time.timeScale = 0.0f;
    }

    public void AddPoints()
    {
        score += 10;
    }


    public void RemovePoints()
    {
        score -= 5;

        if (score < 0) score = 0;
    }

    public int GetScore() { return score; }
}
