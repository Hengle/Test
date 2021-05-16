using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.Events;
public class TrapParticle : MonoBehaviour
{

    ParticleSystem particle;
    public UnityEvent Life;
    bool crRunning;
    // Start is called before the first frame update
    void Start()
    {
        particle = GetComponent<ParticleSystem>();
    }

    // Update is called once per frame
    void OnParticleCollision(GameObject other)
    {
        if (crRunning == false)
        {
            StartCoroutine(invulnerable());
        }
    }
    IEnumerator invulnerable()
    {
        crRunning = true;
        Life.Invoke();
        yield return new WaitForSeconds(3f);
        crRunning = false;
    }
    /*private void MinusLife()
    {
        FindObjectOfType<LifeCount>().LoseLife();
    }*/

}