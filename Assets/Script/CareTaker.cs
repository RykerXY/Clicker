using TMPro;
using UnityEngine;

public class CareTaker : MonoBehaviour
{
    public static int CareTakerLevel = 0;
    public int CareTakerCostForNextLevel = 10;
    public TextMeshProUGUI careTakerLevelDisplay;
    public TextMeshProUGUI careTakerCostDisplay;
    void Start()
    {
        
    }

    void Update()
    {
        careTakerCostDisplay.text = "Upgrade\n" + CareTakerCostForNextLevel + "Coin";
        careTakerLevelDisplay.text = "Level: " + CareTakerLevel;
    }
        public void CareTakerUpgradeClick()
    {
        if (GlobleCoin.CoinCount >= CareTakerCostForNextLevel)
        {
            CareTakerLevel++;
            if(GlobleGlowth.GlowthIncreasePerTime == 0)
            {
                GlobleGlowth.GlowthIncreasePerTime = 1;
            }
            else GlobleGlowth.GlowthIncreasePerTime *= 2;
            GlobleCoin.CoinCount -= CareTakerCostForNextLevel;
            CareTakerCostForNextLevel = CareTakerCostForNextLevel * 3;
            Debug.Log("CareTakerLevel: " + CareTakerLevel);
        }
    }
}
