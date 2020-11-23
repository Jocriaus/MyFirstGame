using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private float CurrentFuel ;
    private bool slowmo;
    public Transform Player1trans;
    private Vector3 LastPos;

    void Start()
    {
        CurrentFuel = GameObject.Find("GameManager").GetComponent<GameManager>().GetFullFuel;
        Player1trans = GetComponent<Transform>();
        LastPos = Player1trans.position;
        //FuelDecrease();
    }

    // Update is called once per frame
    void Update()
    {
        FuelDecrease();
        LastPos = Player1trans.position;
        FuelEmpty();
    }



    public void FuelDecrease() {
        if (GameObject.Find("Top Detector").GetComponent<TopCollider>().TopCollision == false) {
            if (Player1trans.position != LastPos) {
                GameObject.Find("GameManager").GetComponent<GameManager>().PlayParticles();
                CurrentFuel--;
            }
            else {
               // StartCoroutine(StoppingParticles());
            }
        }
    }
    public void FuelEmpty() {

        if (CurrentFuel <= 0) {
            GameObject.Find("GameManager").GetComponent<GameManager>().GameEnded();
        
        }


    }

    public float GetCurrentFuel {
        get {
            return CurrentFuel;
        }
        set {
            this.CurrentFuel = value;
        }
    }
    /*
    IEnumerator StoppingParticles() {
        yield return new WaitForSeconds(2f);

        GameObject.Find("GameManager").GetComponent<GameManager>().StopParticles();
    }
    */





}
