using TMPro;
using UnityEngine;

public class CareTaker1 : MonoBehaviour
{
    public AudioManager audioManager;
    public static int CareTakerLevel1 = 0;
    public static double CareTakerCostForNextLevel1;
    public TextMeshProUGUI careTakerLevelDisplay;
    public TextMeshProUGUI careTakerCostDisplay;
    public TextMeshProUGUI growthIncreasePerTimeDisplay;
    void Update()
    {
        careTakerCostDisplay.text = GlobleCoin.FormatNumberDouble(CareTakerCostForNextLevel1);
        careTakerLevelDisplay.text = "Level: " + CareTakerLevel1;
        if(GlobleGlowth.GlowthIncreasePerTime >= 10000)
        {
            growthIncreasePerTimeDisplay.text = "Glowth Increase: " + GlobleCoin.FormatNumberDouble(GlobleGlowth.GlowthIncreasePerTime1) + "/s";
        }
        else growthIncreasePerTimeDisplay.text = "Glowth Increase: " + GlobleGlowth.GlowthIncreasePerTime1.ToString("F1") + "/s";;
    }
        public void CareTakerUpgradeClick()
    {   
        if (GlobleCoin.CoinCount >= CareTakerCostForNextLevel1)
        {
            audioManager.PlayUpgradeSound();

            CareTakerLevel1++;
            if(GlobleGlowth.GlowthIncreasePerTime1 == 0)
            {
                GlobleGlowth.GlowthIncreasePerTime1 = 1;
            }
            else GlobleGlowth.GlowthIncreasePerTime1 = 1.5f * Mathf.Pow(1.2f, CareTakerLevel1);;
            GlobleCoin.CoinCount -= CareTakerCostForNextLevel1;
            CareTakerCostForNextLevel1 = 1000 * Mathf.Pow(1.5f, CareTakerLevel1);
            //Debug.Log("CareTakerLevel: " + CareTakerLevel1);
            //Debug.Log("GlowthIncreasePerTime1: " + GlobleGlowth.GlowthIncreasePerTime1);
        }
        else
        {
            audioManager.PlayUpgradeFailSound();
        }
    }
}
