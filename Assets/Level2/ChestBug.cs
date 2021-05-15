using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChestBug : MonoBehaviour
{
    public GameObject UI;
    public GameObject Chest;
    public Component off;
    public GameObject wall;

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Chest.SetActive(true);
            UI.SetActive(false);
            wall.SetActive(true);
            off.GetComponent<BoxCollider>().enabled = false;

        }
    }
}
