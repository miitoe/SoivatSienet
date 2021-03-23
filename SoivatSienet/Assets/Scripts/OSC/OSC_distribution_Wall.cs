using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

public class OSC_distribution_Wall : MonoBehaviour {
    
   	public OSC osc;

    private float blue1Int;
    private float blue2Int;
    private float blue3Int;
    private float red1Int;
    private float red2Int;
    private float red3Int;
    private float yellow1Int;
    private float yellow2Int;
    private float yellow3Int;

	// Use this for initialization
	void Start () {
       osc.SetAddressHandler("/red1", red1);
       osc.SetAddressHandler("/red2", red2);
       osc.SetAddressHandler("/red3", red3);
    }
	
	// Update is called once per frame
	void Update () {
	}

    void red1(OscMessage message){
        red1Int = message.GetFloat(0);
        Debug.Log("RED 1:" + red1Int);
	}

    void red2(OscMessage message){

	}

    void red3(OscMessage message){
	}
}