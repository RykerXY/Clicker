using TMPro;
using UnityEngine;

public class CareTaker : MonoBehaviour
{
    public AudioManager audioManager;
    public static int CareTakerLevel = 0;
    public static double CareTakerCostForNextLevel = 10;
    public TextMeshProUGUI careTakerLevelDisplay;
    public TextMeshProUGUI careTakerCostDisplay;
    public TextMeshProUGUI careTakerGlowthIncreaseDisplay;
    void Update()
    {
        careTakerCostDisplay.text = GlobleCoin.FormatNumberDouble(CareTakerCostForNextLevel);
        careTakerLevelDisplay.text = "Level: " + CareTakerLevel;
        if(GlobleGlowth.GlowthIncreasePerTime >= 10000)
        {
            careTakerGlowthIncreaseDisplay.text = "Glowth Increase: " + GlobleCoin.FormatNumberDouble(GlobleGlowth.GlowthIncreasePerTime) + "/s";
        }
        else careTakerGlowthIncreaseDisplay.text = "Glowth Increase: " + GlobleGlowth.GlowthIncreasePerTime.ToString("F1") + "/s";;
    }
    public void CareTakerUpgradeClick()
    {   
        if (GlobleCoin.CoinCount >= CareTakerCostForNextLevel)
        {
            audioManager.PlayUpgradeSound();

            CareTakerLevel++;
            if(GlobleGlowth.GlowthIncreasePerTime == 0)
            {
                GlobleGlowth.GlowthIncreasePerTime = 1;
            }
            else GlobleGlowth.GlowthIncreasePerTime = 1.5f * Mathf.Pow(1.2f, CareTakerLevel);
            GlobleCoin.CoinCount -= CareTakerCostForNextLevel;
            CareTakerCostForNextLevel = 50 * Mathf.Pow(1.5f, CareTakerLevel);
            //Debug.Log("CareTakerLevel: " + CareTakerLevel);
            //Debug.Log("GlowthIncreasePerTime: " + GlobleGlowth.GlowthIncreasePerTime);
        }
        else
        {
            audioManager.PlayUpgradeFailSound();
        }
    }
}
