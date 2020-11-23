using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FuelScript : MonoBehaviour{
    // Start is called before the first frame update
    public Slider FuelBar;
    [SerializeField]
    private ParticleSystem particles;

    public void SetMaxHealth(float Fuel) {
        FuelBar.maxValue = Fuel;
        FuelBar.value = Fuel;
    }
    public void SetFuel(float Fuel) {

        FuelBar.value = Fuel;
    }

    public void PlayParticle() {
        particles.Play(true);

    }

    /*
    public void StopParticle() {
        particles.Stop(true);

    }
    */
}














