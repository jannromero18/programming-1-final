using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    [SerializeField] private float speed;
    
    private Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        InputManager.Init(this); //puts the game controls on the ball
        InputManager.SetStartControls();

        rb = GetComponent<Rigidbody>();

    }

    void FixedUpdate(){
        
    }

    public void StartMovement(){
        rb.AddForce();
    }
}
