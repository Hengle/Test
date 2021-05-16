using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

//[RequireComponent(typeof(BoxCollider))]
public class Trap : MonoBehaviour
{
    bool crRunning = false;
    //public UnityEvent MinusLife;
    //private void Reset()
    //{
    //GetComponent<BoxCollider>().isTrigger = true;
    //}

    /*private void OnTriggerEnter(Collider collision)
    {
        if (collision.tag == "Player")
        {
            Invoke("MinusLife", 0);
            //FindObjectOfType<LifeCount>().LoseLife();
        }
    }*/
    void OnCollisionEnter(Collision other)
    {
        if (crRunning == false)
        {
            StartCoroutine(invulnerable());
            //Invoke("MinusLife", 0);
        }
    }
    private void MinusLife()
    {
        FindObjectOfType<LifeCount>().LoseLife();
    }
    IEnumerator invulnerable()
    {
        crRunning = true;
        Invoke("MinusLife", 0);
        //MinusLife.Invoke();
        yield return new WaitForSeconds(3f);
        crRunning = false;
    }
}