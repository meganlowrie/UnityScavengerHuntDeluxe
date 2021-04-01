using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallingLeaves : MonoBehaviour
{
    public GameObject LeafParticle;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        
        LeafFall();

    }

    void LeafFall()
    {
        LeafParticle.GetComponent<ParticleSystem>().Play();
    }
}
