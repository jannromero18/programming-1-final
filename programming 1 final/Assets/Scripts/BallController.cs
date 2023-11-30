using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    [SerializeField] private float speed;
    
    private Rigidbody rb;

    private Vector3 _moveDirection;

    //private int movement = 0;
    //no movement = 0
    //moving x = 1
    //moving z = 2

    // Start is called before the first frame update
    void Start()
    {
        InputManager.Init(this); //puts the game controls on the ball
        InputManager.SetStartControls();

        rb = GetComponent<Rigidbody>();

    }

    void FixedUpdate(){
        transform.position += speed * Time.deltaTime * _moveDirection;

        /* WAS NOT MOVING IN THE CORRECT DIRECTIONS
        if (movement == 1){
            rb.AddForce(Vector3.left * speed * 0.5f, ForceMode.Impulse);
        }
        else if (movement == 2){
            rb.AddForce(-Vector3.left * speed * 0.5f, ForceMode.Impulse);
        }
        */
    }

    public void StartMovement(){
        //movement = 1; // start going in the x direction
        InputManager.SetInGameControls();
    }

    /*
    public void SwitchMovementDirection(){
        if(movement == 1){
            movement++;
        }
        else{
            movement--;
        }
    }
    */

     public void SetMovementDirection(Vector3 currentDirection){
        _moveDirection = currentDirection;
    }
}
