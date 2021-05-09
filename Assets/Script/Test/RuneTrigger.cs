using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class RuneTrigger : MonoBehaviour
{
    public UnityEvent interact;
    // Start is called before the first frame update

    // Update is called once per frame
    void OnTriggerEnter(Collider other){
        if(other.gameObject.tag == "Player"){
            interact.Invoke();
        }
    }
}
