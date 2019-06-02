using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonController : MonoBehaviour
{
    public AudioSource music;
    public AudioClip sound1;
    public AudioClip sound2;
    public AudioClip sound3;

    public void MoveSound()
    {
        music.PlayOneShot(sound1);
        
    }
    public void ClickButton()
    {
        music.PlayOneShot(sound2);
        music.PlayOneShot(sound3);
       
    }

}
