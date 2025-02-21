using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class GlobleGlowth : MonoBehaviour
{
    public AudioManager AudioManager;
    public static double GlowthCount = 0;
    
    public static int GlowthStage = 0;
    public static int GlowthStageReward = 0;
    public static double GlowthRequiredForNextStage = 20;
    public int GlowthMaxStage = 12;
    public static double GlowthIncreasePerTime = 0;
    public static double GlowthIncreasePerTime1 = 0;
    public TextMeshProUGUI StageDisplay;
    
    [Header("Glowth Stage Image")]
    public Image GlowthStageImage;
    public Sprite GlowthStageImage_1;
    public Sprite GlowthStageImage_2;
    public Sprite GlowthStageImage_3;
    public Sprite GlowthStageImage_4;
    public Sprite GlowthStageImage_5;
    
    public static long StageReward = 100;
    public double increaseDuration = 1f; 
    private bool justReset = false;

    void Start()
    {
        StartCoroutine(GlowthIncrease());
        GlowthStageImage.SetNativeSize();
    }

    void Update()
    {
        if(GlowthCount >= GlowthRequiredForNextStage)
        {
            AudioManager.PlayStageRewardSound();

            GlowthStage++;
            GlowthStageReward++;
            GlowthCount = 0;
            justReset = true; 

            GlowthRequiredForNextStage = GlowthRequiredForNextStage * (1.8f + (0.2f * GlowthStage));

            GlobleCoin.CoinCount += Mathf.CeilToInt(StageReward * (1.2f + (0.05f * GlowthStageReward)));
            Debug.Log("GlowthStage: " + GlowthStage);
        }
        if(GlowthStage == 10)
        {
            GlowthStage = 0;
        }
        StageDisplay.text = "Stage: " + GlowthStage;
        UpdateGlowthStageImage();
        GlowthStageImage.SetNativeSize();
    }

    IEnumerator GlowthIncrease()
    {
        while (true)
        {
            if (justReset)
            {
                justReset = false;
                yield return null;
                continue;
            }

            double startValue = GlowthCount;
            double targetValue = GlowthCount + GlowthIncreasePerTime + GlowthIncreasePerTime1;
            double elapsedTime = 0f;

            if (GlowthIncreasePerTime > 0 || GlowthIncreasePerTime1 > 0)
            {
                while (elapsedTime < increaseDuration)
                {
                    elapsedTime += Time.deltaTime;
                    double newValue = Mathf.RoundToInt(Mathf.Lerp((float)startValue, (float)targetValue, (float)(elapsedTime / increaseDuration)));
                    
                    if(newValue >= GlowthRequiredForNextStage)
                    {
                        GlowthCount = 0;
                        break;
                    }
                    else
                    {
                        GlowthCount = newValue;
                    }
                    yield return null;
                }
            }
            if(GlowthCount < GlowthRequiredForNextStage)
            {
                GlowthCount = Mathf.RoundToInt((float)targetValue);
            }
            yield return null;
        }
    }

    void UpdateGlowthStageImage()
    {
        switch (GlowthStage)
        {
            case 0:
                GlowthStageImage.sprite = GlowthStageImage_1;
                break;
            case 2:
                GlowthStageImage.sprite = GlowthStageImage_2;
                break;
            case 4:
                GlowthStageImage.sprite = GlowthStageImage_3;
                break;
            case 6:
                GlowthStageImage.sprite = GlowthStageImage_4;
                break;
            case 8:
                GlowthStageImage.sprite = GlowthStageImage_5;
                break;
            default:
                break;
        }
    }
}
