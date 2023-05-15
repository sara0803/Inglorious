using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;

public class VolumenSettings : MonoBehaviour
{
    [SerializeField] private AudioMixer _audiomixer;
    

    public void setMusicVolume(float sliderMusic)
    {
        _audiomixer.SetFloat("vol", Mathf.Log10(sliderMusic)*20);
    }

}
