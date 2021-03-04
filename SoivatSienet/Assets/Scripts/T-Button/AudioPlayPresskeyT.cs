using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioPlayPresskeyT : MonoBehaviour
{

    public AudioSource Bblong;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.T))
        {
            if (!Bblong.isPlaying)
            {
                Bblong.Play();

            }
        }
        //if (Input.GetKeyUp(KeyCode.T))
        //{ cLong.Stop();
        //}

    }
}
