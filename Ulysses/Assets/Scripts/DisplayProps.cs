using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisplayProps : MonoBehaviour {
    public bool GameStart = true;
    private float respawnTime;
    public GameObject[] props;
    private int randomness;
    // Start is called before the first frame update
    void Start() {
        randomness = Random.Range(0, props.Length);
        
        respawnTime = Random.Range(5, 10);
        StartCoroutine(PropsWave());
    }

    private void spawnProps() {
        GameObject a = Instantiate(props[randomness], transform.position, Quaternion.identity);
        
    }
    private void Update() {
        
    }

    IEnumerator PropsWave(){
        while (GameStart){
            yield return new WaitForSeconds(respawnTime);
            spawnProps();
        }
    }
}
