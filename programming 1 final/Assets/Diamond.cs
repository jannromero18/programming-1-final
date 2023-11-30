using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Diamond : MonoBehaviour
{
    private void OnTriggerEnter(Collider other){ //box collider isTrigger 
        if(other.transform.tag == "Ball"){
            Destroy(gameObject); 
            BallController.score++;
        }
    }
}