using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [Range(0.0f, 5.0f)]
    public float speed = 1.0f;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

   

    // This function is called a fixed framerate
    private void FixedUpdate()
    {
        float horizontal = Input.GetAxis("Horizontal") * speed / 10;
        float vertical = Input.GetAxis("Vertical") * speed / 10;

        transform.Translate(Vector3.right * horizontal);
        transform.Translate(Vector3.up * vertical);
    }
}
