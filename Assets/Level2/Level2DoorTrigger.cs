using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level2DoorTrigger : MonoBehaviour
{
    Animator doorAnim;
    [SerializeField] GameObject door1;
    [SerializeField] GameObject door2;

    private void OnTriggerEnter(Collider other)
    {
        doorAnim.SetBool("isOpening", true);
        transform.GetChild(0).GetComponent<Animator>();
        transform.GetChild(1).GetComponent<Animator>();
    }
    private void OnTriggerExit(Collider other)
    {
        doorAnim.SetBool("isOpening", false);
    }
    // Start is called before the first frame update
    void Start()
    {
        doorAnim = door1.transform.GetComponent<Animator>();
        doorAnim = door2.transform.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {

    }
}