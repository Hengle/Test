using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorTrigger : MonoBehaviour
{
    Animator doorAnim;
    [SerializeField] GameObject _Gate_L_Portcullis_01te_L_Portcullis_01;
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
        doorAnim = _Gate_L_Portcullis_01te_L_Portcullis_01.transform.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {

    }
}
