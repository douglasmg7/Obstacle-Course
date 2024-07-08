using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    // [SerializeField] float xValue = 0;
    [SerializeField] float yValue = 0;
    // [SerializeField] float zValue = 0;
    [SerializeField] float moveSpeed = 10;

    // Start is called before the first frame update
    void Start()
    {
        PrintInstruction();
        
    }

    // Update is called once per frame
    void Update()
    {
        this.MovePlayer();
    }

    void MovePlayer() {
        transform.Translate(
            Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed, 
            yValue, 
            Input.GetAxis("Vertical") * Time.deltaTime * moveSpeed);
    }

    void PrintInstruction(){
        Debug.Log("Welcome to the game!");
    }
}
