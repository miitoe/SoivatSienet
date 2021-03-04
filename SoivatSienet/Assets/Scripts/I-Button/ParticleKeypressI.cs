using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleKeypressI : MonoBehaviour
{
    public ParticleSystem particles;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.I))
        {
            print("I key is held down");
            particles.Play();
        }

        if (Input.GetKeyUp(KeyCode.I))
        {
            particles.Stop();
            print("I key is up");
        }

    }
}
