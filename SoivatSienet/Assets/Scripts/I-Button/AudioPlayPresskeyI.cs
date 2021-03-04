using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioPlayPresskeyI : MonoBehaviour
{

    public AudioSource Sound;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.I))
        {
            if (!Sound.isPlaying)
            {
                Sound.Play();

            }
        }
        if (Input.GetKeyUp(KeyCode.I))
        { Sound.Stop();
        }

    }
}