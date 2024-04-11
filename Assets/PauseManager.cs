using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseManager : MonoBehaviour
{
    [Tooltip("Key for pausing the game")]
    [SerializeField] KeyCode pauseKey = KeyCode.Escape;

    bool isPaused = false;


    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(pauseKey))
        {
            if(isPaused)
            {
                Time.timeScale = 1.0f;
                isPaused = false;
            } else {
                isPaused = true;
                Time.timeScale = 0.0f;
            }
        }
    }
}
