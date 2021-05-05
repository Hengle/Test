using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SingleBall : MonoBehaviour
{
    private Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = this.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        rb.AddForce(Physics.gravity * rb.mass);
    }
    void OnTriggerEnter(Collider other){
        if(other.gameObject.CompareTag("Player")){
            Debug.Log("Took Damage");
        }
        else if(other.gameObject.CompareTag("Finish")){
            Destroy(this.gameObject);
        }
    }
}
