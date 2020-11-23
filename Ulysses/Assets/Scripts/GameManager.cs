using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    [SerializeField]
    private GameObject GameOverMenu;

    [SerializeField]
    private GameObject FuelIndicator;

    [SerializeField]
    private FuelScript FuelIndicatorScript;

    private bool gameHasEnded = false;
    private float CurrentFuel;
    private float FuelFull = 1000;
    private int currency =  0;

    public void GameEnded() {
        if (!gameHasEnded) {
            gameHasEnded = true;
            FuelIndicator.SetActive(false);
            GameOverMenu.SetActive(true);
            GameObject.Find("Main Camera").GetComponent<Joystick>().enabled = false;
            
        }
    }
    private void Start() {
        FuelIndicatorScript.SetMaxHealth(GetFullFuel);
        GameOverMenu.SetActive(false);
        FuelIndicator.SetActive(true);

    }
    private void Update() {
        CurrentFuel = GameObject.Find("Boat").GetComponent<Player>().GetCurrentFuel;
        FuelIndicatorScript.SetFuel(CurrentFuel);
    }
    public void RestartGame() {

        SceneManager.LoadScene(SceneManager.GetActiveScene().name);

    }

    public float GetFullFuel {
        get {
            return FuelFull;
        }
        set {
            this.FuelFull = value;
        }
    }

    public void PlayParticles() {
        FuelIndicatorScript.PlayParticle();
    }
    /*
    public void StopParticles() {
        FuelIndicatorScript.StopParticle();
    }
    */
}
