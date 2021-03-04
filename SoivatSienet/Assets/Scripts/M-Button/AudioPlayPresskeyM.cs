using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioPlayPresskeyM : MonoBehaviour
{

    public AudioSource Sound;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.M))
        {
            if (!Sound.isPlaying)
            {
                Sound.Play();

            }
        }
        //if (Input.GetKeyUp(KeyCode.M))
        //{ cLong.Stop();
        //}

    }
}
