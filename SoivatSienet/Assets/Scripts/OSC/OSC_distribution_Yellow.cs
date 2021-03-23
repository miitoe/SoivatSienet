using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

public class OSC_distribution_Yellow : MonoBehaviour {
    
   	public OSC osc;
    public ParticleSystem DOT_particle1;
    public ParticleSystem DOT_particle1_2;
    public ParticleSystem DOT_particle2;
    public ParticleSystem DOT_particle2_2;
    public ParticleSystem DOT_particle3;
    public ParticleSystem DOT_particle3_2;
    public GameObject DOT_animation1;
    public GameObject DOT_animation2;
    public GameObject DOT_animation3;

    private float yellow1Int;
    private float yellow2Int;
    private float yellow3Int;

    public float sensitivity = 50;

	// Use this for initialization
	void Start () {
       osc.SetAddressHandler("/yellow1" , yellow1);
       osc.SetAddressHandler("/yellow2", yellow2);
       osc.SetAddressHandler("/yellow3", yellow3);
    }
	
	// Update is called once per frame
	void Update () {
	}

    void yellow1(OscMessage message){
        yellow1Int = message.GetFloat(0);
        DOT_particle1.Play();
        DOT_particle1_2.Play();
        DOT_animation1.GetComponent<Animator>().Play("YDOT01_press");
	}

    void yellow2(OscMessage message){
        DOT_particle2.Play();
        DOT_particle2_2.Play();
        DOT_animation2.GetComponent<Animator>().Play("YDOT02_press");

	}

    void yellow3(OscMessage message){
        DOT_particle3.Play();
        DOT_particle3_2.Play();
        DOT_animation3.GetComponent<Animator>().Play("YDOT03_press");
	}

}