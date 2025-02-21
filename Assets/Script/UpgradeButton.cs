using TMPro;
using Unity.Mathematics;
using UnityEngine;

public class UpgradeButton : MonoBehaviour
{
    public AudioManager audioManager;
    public TextMeshProUGUI LevelDisplay;
    public TextMeshProUGUI UpgradeDisplay;
    public TextMeshProUGUI PoinPerClick;
    public static int PlayerLevel = 0;
    public static double UpgradeCost = 20;

    void Update()
    {
        LevelDisplay.text = "Level: " + PlayerLevel;
        UpgradeDisplay.text = GlobleCoin.FormatNumberDouble(UpgradeCost);
        PoinPerClick.text = "Point Per Click: " + GlobleCoin.FormatNumberDouble(GlobleCoin.CoinIncreasement);
    }

    public void UpgradeLevel()
    {
        if (GlobleCoin.CoinCount >= UpgradeCost)
        {
            audioManager.PlayUpgradeSound();
            PlayerLevel += 1;
            GlobleCoin.CoinCount -= UpgradeCost;
            
            GlobleCoin.CoinIncreasement = math.ceil(GlobleCoin.CoinIncreasement * 1.2f);
            UpgradeCost = math.ceil(UpgradeCost * 1.3f);
        }
        else
        {
            audioManager.PlayUpgradeFailSound();
        }
    }
}
