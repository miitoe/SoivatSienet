using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

public class OSC_distribution_Red : MonoBehaviour {
    
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

    private float red1Int;
    private float red2Int;
    private float red3Int;

    public float sensitivity = 50;

	// Use this for initialization
	void Start () {
       osc.SetAddressHandler("/red1" , red1 );
       osc.SetAddressHandler("/red2", red2);
       osc.SetAddressHandler("/red3", red3);
    }
	
	// Update is called once per frame
	void Update () {
	}

    void red1(OscMessage message){
        red1Int = message.GetFloat(0);
        DOT_particle1.Play();
        DOT_particle1_2.Play();
        DOT_animation1.GetComponent<Animator>().Play("YDOT01_press");
        
        Debug.Log("RED 1:" + red1Int);
	}

    void red2(OscMessage message){
        DOT_particle2.Play();
        DOT_particle2_2.Play();
        DOT_animation2.GetComponent<Animator>().Play("YDOT02_press");

	}

    void red3(OscMessage message){
        DOT_particle3.Play();
        DOT_particle3_2.Play();
        DOT_animation3.GetComponent<Animator>().Play("YDOT03_press");
	}
}