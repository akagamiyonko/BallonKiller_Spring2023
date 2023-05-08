using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 using UnityEngine.UI;
public class SoundSetting : MonoBehaviour
{
    [SerializeField] Slider volumeSlider;
    // Start is called before the first frame update
    void Start()
    {
        if(!PlayerPrefs.HasKey("musicVolume"))                                                                                                                              
        {
            PlayerPrefs.SetFloat("musicVolume", 1);
            load();
        }
        else {
            load();
        }
    }

    
    public void load() {
        PlayerPrefs.GetFloat("musicVolume");
    }


    public void changeVolume()
    {
        AudioListener.volume = volumeSlider.value;
        Save();
    }

    public void Save() {
        PlayerPrefs.SetFloat("musicVolume", volumeSlider.value);
        volumeSlider.value = PlayerPrefs.GetFloat("musicVolume", volumeSlider.value);
    }
}
