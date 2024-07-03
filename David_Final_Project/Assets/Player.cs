using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
//How to make a variable in C#:

public CharacterController controller; // A var that holds the charater's charater controller component

public float movespeed = 5f;

private Vector3 movedirection = Vector3.zero;
            


    // Start is called before the first frame update
    void Start()
    {
        controller = GetComponent<CharacterController>(); //Assign controller to charater controller   
    }

    // Update is called once per frame
    void Update()
    {
       //Player movement input
       float horizontalInput = Input.GetAxis("Horizontal"); //Left and right input fromthe player
       float verticalInput = Input.GetAxis ("Vertical"); //Forward and backward input from the player
       
       
       
       //Calculate the players movement direction
       Vector3 movement = new Vector3(horizontalInput, 0, verticalInput);
       
       
       //Move player based on the input
       controller.Move(movement * movespeed * Time.deltaTime); 
     
    }
}
