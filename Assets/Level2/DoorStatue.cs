using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorStatue : MonoBehaviour
{
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
    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            if (isOpening == true)
            {
                isOpening = false;
                CloseDoor();

            }
        }
    }
    public void OpenDoor()
    {
        animate.SetBool("isOpening", true);
        sound.Play();
    }
    public void CloseDoor()
    {
        animate.SetBool("isOpening", false);
        sound.Play();
    }
}
