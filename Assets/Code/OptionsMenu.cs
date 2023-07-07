using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
public class OptionsMenu : MonoBehaviour
{
    public AudioMixer audioMixer;
    public AudioSource soundPLayer;
    public AudioSource buttonSound;
    
    public void SetVolum (float volume) 
    {
        audioMixer.SetFloat("volume", volume);
    }

    public void playSound ()
    {
        soundPLayer.Play();
    }

    public void playsButton ()
    {
        buttonSound.Play();
    }
}
