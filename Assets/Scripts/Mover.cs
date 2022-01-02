using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour

{
    [SerializeField] float moveSpeed = 1.5f;

    // Start is called before the first frame update
    void Start()
    {
        PrintInstruction();
    }

    // Update is called once per frame
    void Update()
    {
        MovePlayer();
    }

    void PrintInstruction()
    {
        Debug.Log("Welcome to the Obstacle Course!");
        Debug.Log("Press WASD to move.\n Avoid all obstacles and reach the end to win!");
    }

    void MovePlayer()
    {
        float xValue = Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed;
        float zValue = Input.GetAxis("Vertical") * Time.deltaTime * moveSpeed;
        transform.Translate(xValue,0,zValue);
    }
}