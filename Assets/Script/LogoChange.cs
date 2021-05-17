using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LogoChange : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject Sprint1;
    public GameObject Sprint2;
    public GameObject Jump1;
    public GameObject Jump2;
    //public GameObject DJump1;
    //public GameObject DJump2;
    public GameObject Crouch1;
    public GameObject Crouch2;
    public GameObject Dash1;
    public GameObject Dash2;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftShift))
        {
            Sprint1.SetActive(false);
            Sprint2.SetActive(true);
        }
        if (Input.GetKeyUp(KeyCode.LeftShift))
        {
            Sprint1.SetActive(true);
            Sprint2.SetActive(false);
        }
        if (Input.GetKey(KeyCode.F))
        {
            Dash1.SetActive(false);
            Dash2.SetActive(true);
        }
        if (Input.GetKeyUp(KeyCode.F))
        {
            Dash1.SetActive(true);
            Dash2.SetActive(false);
        }
        if (Input.GetKey(KeyCode.C))
        {
            Crouch1.SetActive(false);
            Crouch2.SetActive(true);
        }
        if (Input.GetKeyUp(KeyCode.C))
        {
            Crouch1.SetActive(true);
            Crouch2.SetActive(false);
        }
        if (Input.GetKey(KeyCode.Space))
        {
            Jump1.SetActive(false);
            Jump2.SetActive(true);
        }
        if (Input.GetKeyUp(KeyCode.Space))
        {
            Jump1.SetActive(true);
            Jump2.SetActive(false);
        }
    }
}
