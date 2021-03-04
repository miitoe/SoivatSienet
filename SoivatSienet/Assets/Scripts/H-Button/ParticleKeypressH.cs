using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleKeypressH : MonoBehaviour
{
    // Start is called before the first frame update
    // void Start()
    // {
    // }

    public ParticleSystem particles;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.H))
        {
            print("H key is held down");
            particles.Play();
        }

        if (Input.GetKeyUp(KeyCode.H))
        {
            particles.Stop();
            print("H key is up");
        }

    }
}
