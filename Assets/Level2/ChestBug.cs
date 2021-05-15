using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChestBug : MonoBehaviour
{
    public GameObject UI;
    public GameObject Chest;
    public Component off;

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Chest.SetActive(true);
            UI.SetActive(false);
            off.GetComponent<BoxCollider>().enabled = false;

        }
    }
}
