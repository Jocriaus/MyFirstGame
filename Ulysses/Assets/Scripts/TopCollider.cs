using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TopCollider : MonoBehaviour { 
    public bool TopCollision = false;
    //will detect the collision
    private void OnCollisionStay2D(Collision2D collision) {
        if (collision.gameObject.CompareTag("Obstacles")) {
            TopCollision = true;
        }
    }
    //will notice the exit on collision
    private void OnCollisionExit2D(Collision2D collision) {

        if (collision.gameObject.CompareTag("Obstacles")) {

            Debug.Log("exit");
            TopCollision = false;
        
        }
    }
}
