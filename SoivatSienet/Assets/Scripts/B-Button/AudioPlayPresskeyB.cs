using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioPlayPresskeyB : MonoBehaviour
{

    public AudioSource Sound;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.B))
        {
            if (!Sound.isPlaying)
            {
                Sound.Play();

            }
        }
        //if (Input.GetKeyUp(KeyCode.B))
        //{ cLong.Stop();
        //}

    }
}
