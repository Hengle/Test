using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextLevel : MonoBehaviour
{
    private int SceneLoad;
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            SceneLoad = SceneManager.GetActiveScene().buildIndex + 1;
            SceneManager.LoadScene(SceneLoad);
        }
    }
}
