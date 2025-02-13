using TMPro;
using UnityEngine;

public class UpgradeButton : MonoBehaviour
{
    public TextMeshProUGUI LevelDisplay;
    public TextMeshProUGUI UpgradeDisplay;
    public static int PlayerLevel = 1;
    public int UpgradeCost = 20;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        LevelDisplay.text = "Level: " + PlayerLevel;
        UpgradeDisplay.text = "Upgrade\n" + UpgradeCost + " Coin";
    }

    public void UpgradeLevel()
    {
        if(GlobleCoin.CoinCount >= UpgradeCost)
        {
            PlayerLevel += 1;
            GlobleCoin.CoinCount -= UpgradeCost;
            GlobleCoin.Increasement *= 2;

            UpgradeCost *= 3;
        }
    }
}
