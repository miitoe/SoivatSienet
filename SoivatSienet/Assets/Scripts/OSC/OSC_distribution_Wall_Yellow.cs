using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

public class OSC_distribution_Wall_Yellow : MonoBehaviour {
    
   	public OSC osc;

    public ParticleSystem butterflies;
    public ParticleSystem particles;

    private bool active = false;
    public float waitTime = 10f;

	// Use this for initialization
	void Start () {
       osc.SetAddressHandler("/yellow1", yellowSensorData);
       osc.SetAddressHandler("/yellow2", yellowSensorData);
       osc.SetAddressHandler("/yellow3", yellowSensorData);
    }
	
	// Update is called once per frame
	void Update () {

	}

    void yellowSensorData(OscMessage message){
        if(!active) {
            playYellowParticles();
            active = true;
            StartCoroutine(makeParticlesInactive());
        }
	}

    void playYellowParticles(){
        butterflies.Play();
        particles.Play();
	}

    IEnumerator makeParticlesInactive() {
        yield return new WaitForSeconds(waitTime);// Wait a bit
        active = false;
        Debug.Log("AVAILABLE AGAIN");
    }
}