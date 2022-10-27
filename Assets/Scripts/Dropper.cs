using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dropper : MonoBehaviour
{
    MeshRenderer renderer;
    Rigidbody gravity;
    [SerializeField] float trapTimer = 5.0f;

    // Start is called before the first frame update
    void Start()
    {
        renderer = GetComponent<MeshRenderer>();
        gravity = GetComponent<Rigidbody>(); ;
        renderer.enabled = false;
        gravity.useGravity = false;
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > trapTimer)
        {
            //Debug.Log("Time is up!");
            renderer.enabled = true;
            gravity.useGravity = true;
        }
    }
}
