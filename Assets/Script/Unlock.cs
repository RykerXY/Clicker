using UnityEngine;

public class Unlock : MonoBehaviour
{
    public AudioManager audioSource;
    public double cost;
    void Update()
    {
        
    }
    public void UnlockItem()
    {
        if (GlobleCoin.CoinCount >= cost)
        {
            audioSource.PlayUpgradeSound();
            GlobleCoin.CoinCount -= cost;
            gameObject.SetActive(false);
        }
        else audioSource.PlayUpgradeFailSound();
    }
}
