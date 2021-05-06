using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public GameObject mainm;
    public GameObject howtoplay;
    public GameObject info;
    public GameObject credits;
    public void Start()
    {
        mainm.SetActive(true);
        howtoplay.SetActive(false);
        info.SetActive(false);
        credits.SetActive(false);
    }
    public void infoClicked()
    {
        mainm.SetActive(false);
        info.SetActive(true);
    }
    public void quitClicked()
    {
        Application.Quit();
    }
    public void backClicked()
    {
        mainm.SetActive(true);
        info.SetActive(false);
    }
    public void creditsClicked()
    {
        mainm.SetActive(false);
        credits.SetActive(true);
    }
    public void backCreditsClicked()
    {
        mainm.SetActive(true);
        credits.SetActive(false);
    }
    public void howtoplayClicked()
    {
        mainm.SetActive(false);
        howtoplay.SetActive(true);
    }
    public void backHowtoplayClicked()
    {
        mainm.SetActive(true);
        howtoplay.SetActive(false);
    }
}
