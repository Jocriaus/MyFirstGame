using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SqueezeGameOver : MonoBehaviour
{

    //variables if collided with top or below
    private bool collisionTop = false;
    private bool collisionBot = false;

    //variable if get squashed
    public bool GameOver;

    // variable for the scripts 
    public TopCollider TopColliderScript;
    public BotCollider BotColliderScript;

    // Start is called before the first frame update
    void Start() {

        //referencing other objects scripts
        GameObject TopD = GameObject.Find("Top Detector");
        TopColliderScript = TopD.GetComponent<TopCollider>();

        GameObject BotD = GameObject.Find("Bot Detector");
        BotColliderScript = BotD.GetComponent<BotCollider>();

    }

    // Update is called once per frame
    void Update()
    {
        //assign the value from the other collider scripts
        collisionTop = TopColliderScript.TopCollision;
        collisionBot = BotColliderScript.BotCollision;
        //deploying squeezed method
        Squeezed();

    }

    //will initiate if being squeezed
    public void Squeezed() {

        if (collisionTop && collisionBot) {
            GameOver = true;
            GameObject.Find("GameManager").GetComponent<GameManager>().GameEnded();
        }
        else {
            GameOver = false;
        
        }
    }
    
}

