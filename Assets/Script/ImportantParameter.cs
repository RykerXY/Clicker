using UnityEngine;

public class ImportantParameter : MonoBehaviour
{
    [Header("Coin")]
    public double CoinCount = 0;
    public long CoinIncreasePerTime = 1;
    public long CoinIncreasement = 1;


    [Header("Glowth")]
    public int GlowthCount = 0;
    public int CareTakerLevel = 0;
    public int CareTakerCostForNextLevel = 10;
    public int GlowthIncreasePerTime = 1;
    public int GlowthRequiredForNextStage = 10;



    [Header("Stage Reward")]
    public int StageReward = 100;
    public int RewardMultiplier = 1;

    
    void Start()
    {
        GlobleCoin.CoinCount = CoinCount;
        GlobleCoin.CoinIncreasement = CoinIncreasement;

        GlobleGlowth.GlowthCount = GlowthCount;
        GlobleGlowth.GlowthIncreasePerTime = GlowthIncreasePerTime;
        GlobleGlowth.GlowthRequiredForNextStage = GlowthRequiredForNextStage;

        

        GlobleGlowth.StageReward = StageReward;
    }
    void Update()
    {
        
    }
}
