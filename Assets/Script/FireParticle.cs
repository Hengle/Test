using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class FireParticle : MonoBehaviour
{
    ParticleSystem particle;
    public UnityEvent healthUI;
    bool crRunning;
    // Start is called before the first frame update
    void Start()
    {
        particle = GetComponent<ParticleSystem>();
    }

    // Update is called once per frame
    void OnParticleCollision(GameObject other){
        if(crRunning == false){
            StartCoroutine(invulnerable());
        }
    }
    IEnumerator invulnerable(){
        crRunning = true;
        healthUI.Invoke();
        yield return new WaitForSeconds(3f);    
        crRunning = false;
    }
}
