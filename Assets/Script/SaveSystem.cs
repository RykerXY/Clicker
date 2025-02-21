using UnityEngine;

public class SaveSystem : MonoBehaviour
{
    public GameObject autoclick;
    private int autoclickUnlocked = 1; // 0 = false, 1 = true
    public GameObject caretaker_unlock;
    private int caretakerUnlocked = 1; // 0 = false, 1 = true
    public bool resetting = false;
    public bool setValue = false;
    public bool savegame = false;
    public bool loadgame = false;
    [Header("Setting")]
    public double CoinCount;
    public double CoinIncreasement;

    public int PlayerLevel;
    public double UpgradeCost;

    public double GlowthCount;
    public int GlowthStage;
    public double GlowthRequiredForNextStage;
    public double GlowthIncreasePerTime;
    public double GlowthIncreasePerTime1;
    public long StageReward;
    public int GlowthStageReward;

    public int CareTakerLevel;
    public double CareTakerCostForNextLevel;
    public int CareTakerLevel1;
    public double CareTakerCostForNextLevel1;
    void Start()
    {
        SetValue();
        LoadGame();
    }
    void Update()
    {
        if(resetting)
        {
            ResetGame();
            resetting = false;
        }
        if(setValue)
        {
            SetValue();
            setValue = false;
        }
        if(savegame)
        {
            SaveGame();
            savegame = false;
        }
        if(loadgame)
        {
            LoadGame();
            loadgame = false;
        }

        if(!autoclick.activeSelf)
        {
            autoclickUnlocked = 0;
        }
        if(!caretaker_unlock.activeSelf)
        {
            caretakerUnlocked = 0;
        }
        //Debug.Log(double.Parse(PlayerPrefs.GetString("CoinCount")));
        //Debug.Log(double.Parse(PlayerPrefs.GetString("GlowthCount")));
    }
    void SaveGame()
    {
        //Coin
        PlayerPrefs.SetString("CoinCount", GlobleCoin.CoinCount.ToString());
        PlayerPrefs.SetString("CoinIncreasement", GlobleCoin.CoinIncreasement.ToString());

        PlayerPrefs.SetInt("PlayerLevel", UpgradeButton.PlayerLevel);
        PlayerPrefs.SetString("UpgradeCost", UpgradeButton.UpgradeCost.ToString());

        //Growth
        PlayerPrefs.SetString("GlowthCount", GlobleGlowth.GlowthCount.ToString());
        PlayerPrefs.SetString("GlowthStage", GlobleGlowth.GlowthStage.ToString());
        PlayerPrefs.SetString("GlowthRequiredForNextStage", GlobleGlowth.GlowthRequiredForNextStage.ToString());
        PlayerPrefs.SetString("GlowthIncreasePerTime", GlobleGlowth.GlowthIncreasePerTime.ToString());
        PlayerPrefs.SetString("GlowthIncreasePerTime1", GlobleGlowth.GlowthIncreasePerTime1.ToString());
        PlayerPrefs.SetString("StageReward", GlobleGlowth.StageReward.ToString());
        PlayerPrefs.SetString("GlowthStageReward", GlobleGlowth.GlowthStageReward.ToString());

        //Caretaker
        PlayerPrefs.SetInt("CareTakerLevel", CareTaker.CareTakerLevel);
        PlayerPrefs.SetString("CareTakerCostForNextLevel", CareTaker.CareTakerCostForNextLevel.ToString());
        //Caretaker1
        PlayerPrefs.SetInt("CareTaker1Level", CareTaker1.CareTakerLevel1);
        PlayerPrefs.SetString("CareTaker1CostForNextLevel", CareTaker1.CareTakerCostForNextLevel1.ToString());

        //Unlock
        PlayerPrefs.SetInt("AutoclickUnlock", autoclickUnlocked);
        PlayerPrefs.SetInt("CaretakerUnlock", caretakerUnlocked);
    }
    void LoadGame()
    {
        //Coin
        GlobleCoin.CoinCount = double.Parse(PlayerPrefs.GetString("CoinCount"));
        GlobleCoin.CoinIncreasement = double.Parse(PlayerPrefs.GetString("CoinIncreasement"));

        UpgradeButton.PlayerLevel = PlayerPrefs.GetInt("PlayerLevel");
        UpgradeButton.UpgradeCost = double.Parse(PlayerPrefs.GetString("UpgradeCost"));

        //Growth
        GlobleGlowth.GlowthCount = double.Parse(PlayerPrefs.GetString("GlowthCount"));
        GlobleGlowth.GlowthStage = int.Parse(PlayerPrefs.GetString("GlowthStage"));
        GlobleGlowth.GlowthRequiredForNextStage = double.Parse(PlayerPrefs.GetString("GlowthRequiredForNextStage"));
        GlobleGlowth.GlowthIncreasePerTime = double.Parse(PlayerPrefs.GetString("GlowthIncreasePerTime"));
        GlobleGlowth.GlowthIncreasePerTime1 = double.Parse(PlayerPrefs.GetString("GlowthIncreasePerTime1"));
        GlobleGlowth.StageReward = long.Parse(PlayerPrefs.GetString("StageReward"));
        GlobleGlowth.GlowthStageReward = int.Parse(PlayerPrefs.GetString("GlowthStageReward"));

        //Caretaker
        CareTaker.CareTakerLevel = PlayerPrefs.GetInt("CareTakerLevel");
        CareTaker.CareTakerCostForNextLevel = double.Parse(PlayerPrefs.GetString("CareTakerCostForNextLevel"));
        //Caretaker1
        CareTaker1.CareTakerLevel1 = PlayerPrefs.GetInt("CareTaker1Level");
        CareTaker1.CareTakerCostForNextLevel1 = double.Parse(PlayerPrefs.GetString("CareTaker1CostForNextLevel"));

        //Unlock
        autoclickUnlocked = PlayerPrefs.GetInt("AutoclickUnlock");
        caretakerUnlocked = PlayerPrefs.GetInt("CaretakerUnlock");
        if(autoclickUnlocked == 0){ 
            autoclick.SetActive(false);
        }
        else autoclick.SetActive(true);

        if(caretakerUnlocked == 0)
        {
            caretaker_unlock.SetActive(false);
        }
        else caretaker_unlock.SetActive(true);
    }
    public void ResetGame()
    {
        PlayerPrefs.DeleteAll();
        GlobleCoin.CoinCount = 0;
        GlobleCoin.CoinIncreasement = 1;
        UpgradeButton.PlayerLevel = 1;
        UpgradeButton.UpgradeCost = 50;
        GlobleGlowth.GlowthCount = 0;
        GlobleGlowth.GlowthStage = 1;
        GlobleGlowth.GlowthRequiredForNextStage = 500;
        GlobleGlowth.GlowthIncreasePerTime = 0;
        GlobleGlowth.GlowthIncreasePerTime1 = 0;
        GlobleGlowth.StageReward = 100;
        GlobleGlowth.GlowthStageReward = 1;
        CareTaker.CareTakerLevel = 0;
        CareTaker.CareTakerCostForNextLevel = 200;
        CareTaker1.CareTakerLevel1 = 0;
        CareTaker1.CareTakerCostForNextLevel1 = 2000;
        autoclickUnlocked = 1;
        caretakerUnlocked = 1;
        autoclick.SetActive(true);
        caretaker_unlock.SetActive(true);
    }
    public void SetValue()
    {
        GlobleCoin.CoinCount = CoinCount;
        GlobleCoin.CoinIncreasement = CoinIncreasement;
        UpgradeButton.PlayerLevel = PlayerLevel;
        UpgradeButton.UpgradeCost = UpgradeCost;
        GlobleGlowth.GlowthCount = GlowthCount;
        GlobleGlowth.GlowthStage = GlowthStage;
        GlobleGlowth.GlowthRequiredForNextStage = GlowthRequiredForNextStage;
        GlobleGlowth.GlowthIncreasePerTime = GlowthIncreasePerTime;
        GlobleGlowth.GlowthIncreasePerTime1 = GlowthIncreasePerTime1;
        GlobleGlowth.StageReward = StageReward;
        GlobleGlowth.GlowthStageReward = GlowthStageReward;
        CareTaker.CareTakerLevel = CareTakerLevel;
        CareTaker.CareTakerCostForNextLevel = CareTakerCostForNextLevel;
        CareTaker1.CareTakerLevel1 = CareTakerLevel1;
        CareTaker1.CareTakerCostForNextLevel1 = CareTakerCostForNextLevel1;
        autoclickUnlocked = 1;
        caretakerUnlocked = 1;
    }
    void OnApplicationQuit()
    {
        SaveGame();
    }
    void OnApplicationPause(bool pauseStatus)
    {
        if (pauseStatus)
        {
            SaveGame();
        }
    }
}
