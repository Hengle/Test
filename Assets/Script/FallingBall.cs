using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallingBall : MonoBehaviour
{
    public GameObject objectToSpawn;
    public float spawnTime;
    public float spawnDelay;
    // Start is called before the first frame update
    /*void Start(){
        
    InvokeRepeating("SpawnObject",spawnTime,spawnDelay);
    }*/

    void InvokeSpawning(){
        InvokeRepeating("SpawnObject",spawnTime,spawnDelay);

    }
    public void SpawnObject(){
        GameObject objectSpawned = Instantiate(objectToSpawn,transform.position,transform.rotation);
        
        objectSpawned.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter(Collider other){
        if(other.gameObject.CompareTag("Player")){
            InvokeRepeating("SpawnObject",spawnTime,spawnDelay);
        }
    }
    void OnTriggerExit(Collider other){
        if(other.gameObject.CompareTag("Player")){
            CancelInvoke("SpawnObject");
        }
    }
}
