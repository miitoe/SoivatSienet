using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class OSC_distribution_Blue : MonoBehaviour {
    
   	public OSC osc;
    public ParticleSystem DOT_particle1;
    public ParticleSystem DOT_particle2;
    public ParticleSystem DOT_particle3;
    public float sensitivity = 50;
    private float blue1Int;
    private bool playBlue2 = false;
    private bool playBlue3 = false;

	// Use this for initialization
	void Start () {
       osc.SetAddressHandler("/blue1" , blue1);
       osc.SetAddressHandler("/blue2", blue2);
       osc.SetAddressHandler("/blue3", blue3);
    }

    // Update is called once per frame
	void Update () {
        /*if(blue1Int >= sensitivity) {
            DOT_particle1.Play();
            Debug.Log("PLAY 1: " + blue1Int );
        }
        else if(blue2Int >= sensitivity) {
            DOT_particle2.Play();
            Debug.Log("PLAY 2");
        }
        else if(blue2Int >= sensitivity) {
            DOT_particle3.Play();
            Debug.Log("PLAY 3");
        }*/
	}

    void blue1(OscMessage message){
        if(message.GetFloat(0) > sensitivity) {
            DOT_particle1.Play();
            blue1Int = message.GetFloat(0);
            Debug.Log(blue1Int);
        }
	}

    void blue2(OscMessage message){
        if(message.GetFloat(0) > sensitivity) {
            DOT_particle2.Play();
            playBlue2 = true;
        }
	}

    void blue3(OscMessage message){
        if(message.GetFloat(0) > sensitivity) {
            DOT_particle3.Play();
            playBlue3 = true;
        }
	}

    /* void blue1(OscMessage message){
        if(message.GetFloat(0) > sensitivity) {
            DOT_particle1.Play();
        }
	}

    void blue2(OscMessage message){
        if(message.GetFloat(0) > sensitivity) {
            DOT_particle2.Play();
        }
	}

    void blue3(OscMessage message){
        if(message.GetFloat(0) > sensitivity) {
            DOT_particle3.Play();
        }
	} */

}