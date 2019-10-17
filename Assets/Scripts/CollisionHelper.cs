using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionHelper : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.gameObject.name == "veichle")
        {
            var particleSystem = gameObject.GetComponent<ParticleSystem>();
            if(particleSystem!=null && !particleSystem.isPlaying)
            {
                particleSystem.Play();
                gameObject.GetComponent<MeshRenderer>().enabled = false;
                Destroy(gameObject, 2f);
            }
        }
    }
}
