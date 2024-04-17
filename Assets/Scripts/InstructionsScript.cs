using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstructionsScript : MonoBehaviour
{
    [SerializeField] GameObject instructionsMenu;
    [SerializeField] GameObject mainMenu;
    [SerializeField] GameObject levelMenu;

    static bool firstTime = true;
    static bool goToLevelSelector = false;

    public void OpenLevelSelector()
    {
        goToLevelSelector = true;
    }

    private void Awake()
    {
        Debug.Log("Awake");
        if (firstTime) {
            DontDestroyOnLoad(gameObject);
            if (!goToLevelSelector) {
                instructionsMenu.SetActive(true);
                firstTime = false;
            } else { 
                levelMenu.SetActive(true);
                goToLevelSelector = false;
            }
        } else {
            if (!goToLevelSelector) {
                mainMenu.SetActive(true);
            } else {
                levelMenu.SetActive(true);
                goToLevelSelector = false;
            }
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
