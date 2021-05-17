using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key1 : MonoBehaviour
{
    public GameObject chest;
    public GameObject chestgone;
    public GameObject flame;
    public GameObject flamelight;
    public GameObject keygone;
    public GameObject UI;
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
                chest.SetActive(true);
                chestgone.SetActive(false);
                flame.SetActive(true);
                flamelight.SetActive(true);
                keygone.SetActive(false);
                UI.SetActive(false);
                if (isOpening == false)
                {
                    isOpening = true;
                    OpenDoor();

                }
            }
        }
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            UI.SetActive(true);
        }
    }
    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            UI.SetActive(false);
        }
    }
}
