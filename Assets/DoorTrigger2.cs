using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorTrigger2 : MonoBehaviour
{
    Animator doorAnim;
    [SerializeField] GameObject SM_Bld_Castle_Wall_Gate_L_Door_L_01;
    private void OnTriggerEnter(Collider other)
    {
        doorAnim.SetBool("isOpening", true);
    }
    private void OnTriggerExit(Collider other)
    {
        doorAnim.SetBool("isOpening", false);
    }
    // Start is called before the first frame update
    void Start()
    {
        doorAnim = SM_Bld_Castle_Wall_Gate_L_Door_L_01.transform.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {

    }
}
