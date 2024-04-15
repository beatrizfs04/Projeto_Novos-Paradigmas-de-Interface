using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Activator : MonoBehaviour
{

    public KeyCode key;
    bool isActive = false;
    GameObject note;
    Transform tranform;

    [SerializeField] bool creatorMode;
    [SerializeField] GameObject noteToCreate;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void Awake()
    {
        tranform = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        if(creatorMode && Input.GetKeyDown(key))
        {
            Instantiate(noteToCreate, tranform.position, new Quaternion());
            return;
        }


        if(Input.GetKeyDown(key) && isActive)
        {
            GameObject.Find("Main Camera").GetComponent<PauseManager>().AddPoints();
            Destroy(note);
        } else if(Input.GetKeyDown(key) && !isActive)
        {
            GameObject.Find("Main Camera").GetComponent<PauseManager>().RemovePoints();
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Note")
        {
            isActive = true;
            note = collision.gameObject;
        }

        if (collision.gameObject.tag == "EndNote")
        {
            Destroy(collision.gameObject);
            EndGame();
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Note")
        {
            isActive = false;
            if (creatorMode) collision.gameObject.GetComponent<Note>().setCreatorMode(creatorMode);
        }
    }

    public void EndGame()
    {
        GameObject.Find("Main Camera").GetComponent<PauseManager>().FinishGame();
    }
}
