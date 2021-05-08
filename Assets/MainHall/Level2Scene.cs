using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Level2Scene : MonoBehaviour
{
    //public static bool GameIsPaused = false;
    public GameObject Level1;
    private int SceneLoad;

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Level1.SetActive(true);
            Time.timeScale = 0f;
            //GameIsPaused = true;
        }
    }

    public void No()
    {
        Level1.SetActive(false);
        Time.timeScale = 1f;
        //GameIsPaused = false;
    }

    public void Yes()
    {
        Time.timeScale = 1f;
        SceneLoad = SceneManager.GetActiveScene().buildIndex + 2;
        SceneManager.LoadScene(SceneLoad);
    }
}
