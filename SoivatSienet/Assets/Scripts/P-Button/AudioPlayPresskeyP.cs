using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioPlayPresskeyP : MonoBehaviour
{

    public AudioSource Sound;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            if (!Sound.isPlaying)
            {
                Sound.Play();

            }
        }
        if (Input.GetKeyUp(KeyCode.P))
        {
            Sound.Stop();
        }

    }
}