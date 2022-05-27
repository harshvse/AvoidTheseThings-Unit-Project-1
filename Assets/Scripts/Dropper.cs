using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dropper : MonoBehaviour
{

    MeshRenderer meshRenderer;
    Rigidbody rb;
    [SerializeField] float timeToWait = 5f;

    // Start is called before the first frame update
    void Start()
    {
        meshRenderer = GetComponent<MeshRenderer>();
        rb = GetComponent<Rigidbody>();
        rb.useGravity = false;
        meshRenderer.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(Time.time > timeToWait)
        {
            meshRenderer.enabled = true;
            rb.useGravity = true;
        }
    }
}
