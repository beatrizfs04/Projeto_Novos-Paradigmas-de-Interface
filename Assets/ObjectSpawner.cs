using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectSpawner : MonoBehaviour
{

    public GameObject foodToSpawn;

    private GameObject upSpawner;
    private GameObject downSpawner;
    private GameObject leftSpawner;
    private GameObject rightSpawner;
    private GameObject handSpawner;

    private GameObject upCollider;
    private GameObject downCollider;
    private GameObject leftCollider;
    private GameObject rightCollider;
    private GameObject handCollider;
    // Start is called before the first frame update
    void Start()
    {

        upSpawner = GameObject.FindWithTag("Up Spawner");
        downSpawner = GameObject.FindWithTag("Down Spawner");
        leftSpawner = GameObject.FindWithTag("Left Spawner");
        rightSpawner = GameObject.FindWithTag("Right Spawner");
        handSpawner = GameObject.FindWithTag("Hand Spawner");

        upCollider = GameObject.FindWithTag("Up");
        downCollider = GameObject.FindWithTag("Down");
        leftCollider = GameObject.FindWithTag("Left");
        rightCollider = GameObject.FindWithTag("Right");
        handCollider = GameObject.FindWithTag("Hand");
    }
    // Fixed Update is Called every Fixed Framerate Frame (100 fps)
    private void FixedUpdate()
    {
        
    }


}
