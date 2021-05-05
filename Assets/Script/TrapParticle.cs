using UnityEngine;
using System.Collections;
using System.Collections.Generic;
public class TrapParticle : MonoBehaviour
{

    private void Start()
    {
        ParticleSystem ps = GetComponent<ParticleSystem>();
        var coll = ps.collision;
        coll.enabled = true;
        coll.bounce = 0.5f;
    }
    private void OnParticleTrigger(Collider collision)
    {
        if (collision.tag == "Player")
        {
            Invoke("MinusLife", 1);

        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        Invoke("MinusLife", 1);
    }
    private void OnTriggerEnter(Collider collision)
    {
        if (collision.tag == "Player")
        {
            Invoke("MinusLife", 1);

        }
    }
    private void MinusLife()
    {
        FindObjectOfType<LifeCount>().LoseLife();
    }

}