using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using TMPro;

[System.Serializable]
public class StatueEvent : UnityEvent<bool>{

}
public class RotatingStatue : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    bool isDefined;
    int statueNumber;
    public StatueEvent eventMessage;
    AudioSource audio;

    // Start is called before the first frame update
    void Awake()
    {
        audio = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void doRotation(int number){
        if(isDefined == false){
            statueNumber = number;
            isDefined = true;
        }
        if(statueNumber == 1){
        transform.Rotate(Vector3.up * -50f * Time.deltaTime);
        }else if(statueNumber == 2 ){
            transform.Rotate(Vector3.up * 50f * Time.deltaTime);
        }
        if(statueNumber != null){
            checkRotation(statueNumber);
        }
        if(!audio.isPlaying)
        audio.PlayOneShot(audio.clip,1F);
        scoreText.text = "Current Rotation(For Testing only) : " + transform.localEulerAngles.y.ToString();
        Debug.Log(transform.localEulerAngles.y);
    }
    void checkRotation (int number){
        if(number == 1){
            if(transform.localEulerAngles.y <= 250 && transform.localEulerAngles.y >= 240){
                eventMessage.Invoke(true);
            }else {
                 eventMessage.Invoke(false);
            }
        }else if (number == 2){
            if(transform.localEulerAngles.y <= 120 && transform.localEulerAngles.y >= 110){
                eventMessage.Invoke(true);
            }else {
                eventMessage.Invoke(false);
            }
        }
    }
}
