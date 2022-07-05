using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class VolumeControl : MonoBehaviour
{
    public AudioMixer mixer;
    private float prevVolume = 0;
    private bool mixerOff;

    public void SetVolume(float volume)
    {
        if (!mixerOff)
        {
            mixer.SetFloat("MusicVolume", Mathf.Log10(volume) * 20);
        }
    }

    public void MuteMusic(bool onOff)
    {
        mixerOff = onOff;
        if (mixerOff)
        {
            mixer.GetFloat("MusicVolume", out prevVolume);
            //Debug.Log(prevVolume);
            mixer.SetFloat("MusicVolume", -60);
        }
        else
        {
            mixer.SetFloat("MusicVolume", prevVolume);
            prevVolume = 0;
        }
    }
}
