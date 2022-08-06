using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaySOunds : MonoBehaviour
{
    public AudioSource soundPlayer;
    public AudioSource soundPlayer2;
    
    public void playSoundEffect(){
        soundPlayer2.Stop();
        soundPlayer.Play();
    }

   /* public void playSoundEffect2(){
        soundPlayer2.Play();
        soundPlayer.Stop();
    }*/
}
