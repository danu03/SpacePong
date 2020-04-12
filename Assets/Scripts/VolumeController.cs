using System.Collections;
using System.Collections.Generic;
using UnityEngine.Audio;
using UnityEngine;

public class VolumeController : MonoBehaviour
{

    public AudioMixer audioMixer;
   
    public void MasterVolume(float volume)
    {
        audioMixer.SetFloat("masterVolume", volume);
    }
    public void MusicVolume(float volume)
    {
        audioMixer.SetFloat("musicVolume", volume);
    }

    public void SfxVolume(float volume)
    {
        audioMixer.SetFloat("sfxVolume", volume);
    }
}
