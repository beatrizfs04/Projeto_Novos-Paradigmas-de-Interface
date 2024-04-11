using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
            Instantiate(note, tranform.position, new Quaternion());
            return;
        }


        if(Input.GetKeyDown(key) && isActive)
        {
            Debug.Log("Destroy note");
            Destroy(note);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Note")
        {
            isActive = true;
            note = collision.gameObject;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Note")
        {
            isActive = false;
            
        }
    }
}
