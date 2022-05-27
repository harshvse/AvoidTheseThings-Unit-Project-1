using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField] float xValue = 0;
    [SerializeField] float zValue = 0;
    [SerializeField] float speed = 10;

    // Start is called before the first frame update
    void Start()
    {
        PrintInstructions();
    }

    // Update is called once per frame
    void Update()
    {
        MovePlayer();
    }

    void MovePlayer()
    {
        xValue = Input.GetAxis("Horizontal");
        zValue = Input.GetAxis("Vertical");
        transform.Translate(new Vector3(xValue, 0, zValue) * Time.deltaTime * speed);
    }

    void PrintInstructions()
    {
        Debug.Log("Welcome to obstacle course");
        Debug.Log("Use WSAD to move around");
        Debug.Log("Avoid the obstacles and get to the end of the level");
    }
}
