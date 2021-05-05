using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
//using Manager;

[System.Serializable]
public class MyEvents : UnityEvent<int>{

}
public class HealthManager : MonoBehaviour
{
    public int health;
    public int numOfHearts;
    public Image[] hearts;
    public Sprite fullHeart;
    public Sprite emptyHeart;
    public MyEvents gm;
    public UnityEvent death;

    void Awake(){
        for (int i = 0 ; i < hearts.Length; i++){
            if(i < numOfHearts){
                hearts[i].enabled = true;
            }else {
                hearts[i].enabled = false;
            }
        }
    }

    public void HeartStates(bool takeDamage){
        if(takeDamage){
        health -= 1;
        for (int i = 0 ; i < hearts.Length ; i ++){
            if ( i < health){
                hearts[i].sprite = fullHeart;
            }else {
                hearts[i].sprite = emptyHeart;
            }
        }
        takeDamage = false;
        }
        if(health <= 0){
            death.Invoke();
        }
    }
    public void AddPowerups(bool addNew){
        if(addNew){
            health += 1;
            
            for (int i = 0 ; i < hearts.Length ; i ++){
            if ( i < health){
                hearts[i].sprite = fullHeart;
            }else {
                hearts[i].sprite = emptyHeart;
            }
        }
        addNew = false;
        gm.Invoke(health);
        }
    }
    public void UsePowerUps(bool addNew){
        if(addNew){
            health -= 1;
            
            for (int i = 0 ; i < hearts.Length ; i ++){
            if ( i < health){
                hearts[i].sprite = fullHeart;
            }else {
                hearts[i].sprite = emptyHeart;
            }
        }
        addNew = false;
        gm.Invoke(health);
        }

    }
}
