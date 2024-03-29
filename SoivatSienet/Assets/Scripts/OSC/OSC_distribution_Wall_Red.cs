﻿using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

public class OSC_distribution_Wall_Red : MonoBehaviour {
    
    public OSC osc;

    public ParticleSystem butterflies;
    public ParticleSystem particles;
    private float redMessage;

    private bool active = false;
    public float waitTime = 10f;

	// Use this for initialization
	void Start () {
       //osc.SetAddressHandler("/red1", redSensorData);
       //osc.SetAddressHandler("/red2", redSensorData);
       //osc.SetAddressHandler("/red3", redSensorData);
    }
	
	// Update is called once per frame
	void Update () {
        osc.SetAddressHandler("/playRed", redSensorData);
	}

    void redSensorData(OscMessage message){
        redMessage = message.GetFloat(0);
        if(!active) {
            playRedParticles();
            active = true;
            StartCoroutine(makeParticlesInactive());
        }
	}

    void playRedParticles(){
        butterflies.Play();
        particles.Play();
	}

    IEnumerator makeParticlesInactive() {
        yield return new WaitForSeconds(waitTime);// Wait a bit
        active = false;
    }
}