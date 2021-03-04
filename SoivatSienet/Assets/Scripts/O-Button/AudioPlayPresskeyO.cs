using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioPlayPresskeyO : MonoBehaviour
{

    public AudioSource Sound;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.O))
        {
            if (!Sound.isPlaying)
            {
                Sound.Play();

            }
        }
        if (Input.GetKeyUp(KeyCode.O))
        {
            Sound.Stop();
        }

    }
}
