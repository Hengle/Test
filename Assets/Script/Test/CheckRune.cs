using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckRune : MonoBehaviour
{
    public List<int> runeOrder = new List<int>();
    public List<Transform> statues;
    bool isOpened;
    // Start is called before the first frame update
    void Awake()
    {
        statues.Add(this.transform.GetChild(0));
        statues.Add(this.transform.GetChild(1));
        statues.Add(this.transform.GetChild(2));
        statues.Add(this.transform.GetChild(3));
        statues.Add(this.transform.GetChild(4));
        statues.Add(this.transform.GetChild(5));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void AppdentRune(int value){
        if(!runeOrder.Contains(value)){
        runeOrder.Add(value);
        statues[value - 1].GetChild(0).GetComponent<ParticleSystem>().Play();
        statues[value - 1].GetComponent<AudioSource>().Play();
        }

        if(runeOrder.Count == 5 && isOpened == false){
        if(runeOrder[0] == 1 && runeOrder[1] == 2 && runeOrder[2] == 3 && runeOrder[3] == 4 && runeOrder[4] == 5){
            statues[5].GetComponent<Animation>().Play();
            statues[5].GetComponent<AudioSource>().Play();
            isOpened = true;
        }else{
            for(int i = 0 ; i<statues.Count - 1; i++){
            statues[i].GetChild(0).GetComponent<ParticleSystem>().Stop(true, ParticleSystemStopBehavior.StopEmittingAndClear);
            }
            runeOrder.Clear();
        }
    }
}
}
