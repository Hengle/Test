using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chest1 : MonoBehaviour
{
    public Component key1;
    public GameObject keygone;
    Animator animate;
    AudioSource sound;
    bool isOpening;

    // Start is called before the first frame update
    void Awake()
    {
        animate = GetComponent<Animator>();
        sound = GetComponent<AudioSource>();
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            if (isOpening == false)
            {
                isOpening = true;
                OpenDoor();

            }
        }
    }

    void OnTriggerStay(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            if (Input.GetKey(KeyCode.E))
            {
                key1.GetComponent<BoxCollider>().enabled = true;
                keygone.SetActive(false);
            }
        }
    }
    public void OpenDoor()
    {
        animate.SetBool("isOpening", true);
        sound.Play();
    }
}
