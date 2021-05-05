using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Lightbug.CharacterControllerPro.Core;
using Lightbug.CharacterControllerPro.Demo;
using Lightbug.Utilities;
using Lightbug.CharacterControllerPro.Implementation;


public class AudioController : MonoBehaviour
{
    CharacterActor normalMovement = null;
    CharacterBrain characterBrain;
    CharacterState state  = null;
    AudioSource[] audioPlaying;
    public AudioClip[] movementClips;
    public AudioClip[] jumpClip;
    public AudioListener audioListener;
    NormalMovement sss;
    public bool groundedJump;
    public Animator anim;
    
    
    int jumpCounter;
    // Start is called before the first frame update
  void Awake(){
      audioPlaying =GetComponents<AudioSource>();
      
  }
  void Start(){
      
      normalMovement = GetComponent<CharacterActor>();
      sss = this.GetComponentInBranch<NormalMovement>();
  }

    // Update is called once per frame  
    void LateUpdate()
    {    
    
    if(normalMovement.IsGrounded){
        if(normalMovement.PlanarVelocity.magnitude > 0.01f && normalMovement.PlanarVelocity.magnitude < 6f &&!audioPlaying[0].isPlaying  ){
            audioPlaying[0].volume = Mathf.Clamp(( normalMovement.PlanarVelocity.magnitude / 5), .2f,.4f);
            audioPlaying[0].pitch = Mathf.Clamp(( normalMovement.PlanarVelocity.magnitude / 5), .4f,1f);
            PlayRandomWalk(0);
        }else if(Input.GetKey(KeyCode.LeftShift) && normalMovement.PlanarVelocity.magnitude > 5f && !audioPlaying[0].isPlaying){
            audioPlaying[0].volume = Mathf.Clamp(( normalMovement.PlanarVelocity.magnitude / 10), .5f,.8f);
            audioPlaying[0].pitch = Mathf.Clamp(( normalMovement.PlanarVelocity.magnitude / 10), 0.6f,1f);
            PlayRandomWalk(5);
        }
     }
     /*if(Input.GetKeyDown(KeyCode.Space) && normalMovement.IsStable && audioPlaying[1].isPlaying == false){
                PlayRandomJump();
                jumpCounter = 1;
     }else if(Input.GetKeyDown(KeyCode.Space) &&  audioPlaying[1].isPlaying == false && jumpCounter == 1 ){
         PlayRandomJump();
                jumpCounter = 0;
     }*/
        

        /*
        if (audioPlaying.isPlaying && normalMovement.PlanarVelocity.magnitude <= 0f){
            audioPlaying.Stop();
        }*/
    }
    void PlayRandomWalk(int range){
        audioPlaying[0].clip = movementClips[Random.Range(range, range + 4 )];
        audioPlaying[0].Play();
    }
    public void PlayRandomJump(){
        if(!audioPlaying[1].isPlaying){
        audioPlaying[1].clip = jumpClip[Random.Range(0,2)];
        audioPlaying[1].Play();}
      
        }
    }

