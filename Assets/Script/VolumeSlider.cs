using UnityEngine;
using UnityEngine.UI;

public class VolumeSlider : MonoBehaviour
{
    public AudioSource audioSource;
    private Slider slider;
    void Start()
    {
        slider = GetComponent<Slider>();
        slider.value = audioSource.volume;
    }
    void Update()
    {
        audioSource.volume = slider.value;
        PlayerPrefs.SetFloat("volume", audioSource.volume);
    }
}
