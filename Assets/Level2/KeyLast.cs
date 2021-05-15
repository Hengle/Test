using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyLast : MonoBehaviour
{
    public Component door;
    public GameObject flame;
    public GameObject keygone;
    Animator animate;
    AudioSource sound;
    bool isOpening;

    void Awake()
    {
        animate = GetComponent<Animator>();
        sound = GetComponent<AudioSource>();
    }
    public void OpenDoor()
    {
        animate.SetBool("isOpening", true);
        sound.Play();
    }
    void OnTriggerStay(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            if (Input.GetKey(KeyCode.E))
            {
                door.GetComponent<BoxCollider>().enabled = true;
                flame.SetActive(true);
                keygone.SetActive(false);
                if (isOpening == false)
                {
                    isOpening = true;
                    OpenDoor();

                }
            }
        }
    }
}
