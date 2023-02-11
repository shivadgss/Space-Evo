using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SoundSlider : MonoBehaviour
{
    public Slider mainSlider;
    public Slider musicSlider;
    

    public AudioSource music;
    

    // Start is called before the first frame update
    void Start()
    {
        musicSlider.value = 1f;
        mainSlider.value = 1f;
    }

    public void ChangeMainVol()
    {
        AudioListener.volume = mainSlider.value;
    }
    
    public void ChangeMusicVol()
    {
        music.volume = musicSlider.value;
    }

   
}
