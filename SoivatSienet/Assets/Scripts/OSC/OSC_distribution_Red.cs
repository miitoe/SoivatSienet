using UnityEngine;
using System.Collections;

public class OSC_distribution_Red : MonoBehaviour {
    
   	public OSC osc;
    public ParticleSystem DOT_particle1;
    public ParticleSystem DOT_particle1_2;
    public ParticleSystem DOT_particle2;
    public ParticleSystem DOT_particle2_2;
    public ParticleSystem DOT_particle3;
    public ParticleSystem DOT_particle3_2;
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
        DOT_particle1.Play();
        DOT_particle1_2.Play();
	}

    void red2(OscMessage message){
        DOT_particle2.Play();
        DOT_particle2_2.Play();

	}

    void red3(OscMessage message){
        DOT_particle3.Play();
        DOT_particle3_2.Play();
	}

}