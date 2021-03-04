using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleKeypressN : MonoBehaviour
{
    public ParticleSystem particles;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.N))
        {
            print("N key is held down");
            particles.Play();
        }

        if (Input.GetKeyUp(KeyCode.N))
        {
            particles.Stop();
            print("N key is up");
        }

    }
}

