using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LanguagesButtonsBehav : MonoBehaviour
{
    public GameObject Panel;
    public AudioSource soundPlayer;
    public AudioSource soundPlayer2;

   

    public void playSoundEffect1(){
        soundPlayer.Play();
    }
    public void closePanel()
    {
        if(Panel != null ){
            Panel.SetActive(!Panel.activeSelf);
        }
    }

     public void stopSoundEffect1(){
        soundPlayer.Stop();
    }




}
