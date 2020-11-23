using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BotCollider : MonoBehaviour
{

    public bool BotCollision = false ;
    // Start is called before the first frame update


    //will detect the collision
    private void OnCollisionStay2D(Collision2D collision) {


        if (collision.gameObject.CompareTag("lowerwall")) {
            BotCollision = true;
        }

    }
    //will notice the exit on collision
    private void OnCollisionExit2D(Collision2D collision) {

        if (collision.gameObject.CompareTag("lowerwall")) {
            Debug.Log("exit");
            BotCollision = false;
        }
    }



}



