using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleKeypressM : MonoBehaviour
{
    public ParticleSystem particles;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.M))
        {
            print("M key is held down");
            particles.Play();
        }

        if (Input.GetKeyUp(KeyCode.M))
        {
            particles.Stop();
            print("M key is up");
        }

    }
}