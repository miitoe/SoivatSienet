using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

public class OSC_distribution_Blue : MonoBehaviour {
    
   	public OSC osc;
    public ParticleSystem DOT_particle1;
    public ParticleSystem DOT_particle2;
    public ParticleSystem DOT_particle3;
    public ParticleSystem DOT_smallParticle1;
    public ParticleSystem DOT_smallParticle2;
    public ParticleSystem DOT_smallParticle3;
    public float sensitivity = 1;

    public OscMessage message = new OscMessage();

    private float blue1Int;
    private float blue2Int;
    private float blue3Int;
    public GameObject DOT_animation1;
    public GameObject DOT_animation2;
    public GameObject DOT_animation3;
    public ParticleSystem DOT_splineAnimation1;
    public ParticleSystem DOT_splineAnimation2;
    public ParticleSystem DOT_splineAnimation3;

	// Use this for initialization
	void Start () {
       osc.SetAddressHandler("/blue1" , blue1);
       osc.SetAddressHandler("/blue2", blue2);
       osc.SetAddressHandler("/blue3", blue3);
    }

    // Update is called once per frame
	void Update () {
        if(blue1Int < sensitivity) {
            DOT_splineAnimation1.Stop();
            DOT_animation1.GetComponent<Animator>().Play("BDOT04_idle");
            DOT_particle1.Stop();
            DOT_smallParticle1.Stop();
            DOT_splineAnimation1.Play();
        }

        if(blue2Int < sensitivity) {
            DOT_animation2.GetComponent<Animator>().Play("BDOT05_idle");
            DOT_splineAnimation2.Stop();
            DOT_particle2.Stop();
            DOT_smallParticle2.Stop();
            DOT_splineAnimation2.Play();
        }

        if(blue3Int < sensitivity) {
            DOT_animation3.GetComponent<Animator>().Play("BDOT06_idle");
            DOT_splineAnimation3.Stop();
            DOT_particle3.Stop();
            DOT_smallParticle3.Stop();
            DOT_splineAnimation3.Play();
        }
	}

    void blue1(OscMessage message){
        blue1Int = message.GetFloat(0);
       
        if(blue1Int > sensitivity) {
            //DOT_splineAnimation1.Play();
            DOT_animation1.GetComponent<Animator>().Play("BDOT04_press");
            DOT_particle1.Play();
            DOT_smallParticle1.Play();

            message.address = "/playBlue";
            message.values.Add( 100 );
            osc.Send(message);
        }
	}

    void blue2(OscMessage message){
        blue2Int = message.GetFloat(0);
       // DOT_splineAnimation2.Play();
        if(blue2Int > sensitivity) {
            DOT_animation2.GetComponent<Animator>().Play("BDOT05_press");
            DOT_particle2.Play();
            DOT_smallParticle2.Play();

            message.address = "/playBlue";
            message.values.Add( 100 );
            osc.Send(message);
        }
	}

    void blue3(OscMessage message){
        blue3Int = message.GetFloat(0);
        //DOT_splineAnimation3.Play();
        if(blue3Int > sensitivity) {
            DOT_animation3.GetComponent<Animator>().Play("BDOT06_press");
            DOT_particle3.Play();
            DOT_smallParticle3.Play();

            message.address = "/playBlue";
            message.values.Add( 100 );
            osc.Send(message);
        }
	}
}