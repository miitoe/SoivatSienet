using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioPlayPresskeyN : MonoBehaviour
{

    public AudioSource Sound;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.N))
        {
            if (!Sound.isPlaying)
            {
                Sound.Play();

            }
        }
        //if (Input.GetKeyUp(KeyCode.N))
        //{ cLong.Stop();
        //}

    }
}
