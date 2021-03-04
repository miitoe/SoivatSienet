using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleKeypressB : MonoBehaviour
{
    public ParticleSystem particles;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.B))
        {
            print("B key is held down");
            particles.Play();
        }

        if (Input.GetKeyUp(KeyCode.B))
        {
            particles.Stop();
            print("B key is up");
        }

    }
}
