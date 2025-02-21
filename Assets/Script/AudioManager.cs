using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioClip BGM;
    public AudioClip StageRewardSound;
    public AudioClip UpgradeSound;
    public AudioClip UpgradeFailSound;


    void Start()
    {
        playBGM();
    }
    void Update()
    {
        
    }
    public void PlayStageRewardSound()
    {
        audioSource.PlayOneShot(StageRewardSound);
    }
    public void PlayUpgradeSound()
    {
        audioSource.PlayOneShot(UpgradeSound);
    }
    public void PlayUpgradeFailSound()
    {
        audioSource.PlayOneShot(UpgradeFailSound);
    }
    void playBGM()
    {
        audioSource.clip = BGM;
        audioSource.Play();
        audioSource.loop = true;
    }
}
