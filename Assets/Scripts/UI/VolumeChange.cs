using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class VolumeChange : MonoBehaviour
{
    [SerializeField] private AudioMixer masterAudioMixer;
    [SerializeField] private AudioMixer SFXAudioMixer;

    public void ChangeMusic(float volume)
    {
        masterAudioMixer.SetFloat("MasterVolume", volume);
    }

    public void SFXChangeMusic(float volume)
    {
        SFXAudioMixer.SetFloat("SFXVolume", volume);
    }

}
