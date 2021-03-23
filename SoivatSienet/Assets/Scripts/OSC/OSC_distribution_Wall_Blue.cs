﻿using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

public class OSC_distribution_Wall_Blue : MonoBehaviour {
    
   	public OSC osc;

    public ParticleSystem butterflies;
    public ParticleSystem particles;

    private bool active = false;
    public float waitTime = 10f;

	// Use this for initialization
	void Start () {
       osc.SetAddressHandler("/blue1", blueSensorData);
       osc.SetAddressHandler("/blue2", blueSensorData);
       osc.SetAddressHandler("/blue3", blueSensorData);
    }
	
	// Update is called once per frame
	void Update () {

	}

    void blueSensorData(OscMessage message){
        if(!active) {
            playBlueParticles();
            active = true;
            StartCoroutine(makeParticlesInactive());
        }
	}

    void playBlueParticles(){
        butterflies.Play();
        particles.Play();
	}

    IEnumerator makeParticlesInactive() {
        yield return new WaitForSeconds(waitTime);// Wait a bit
        active = false;
        Debug.Log("AVAILABLE AGAIN");
    }

}