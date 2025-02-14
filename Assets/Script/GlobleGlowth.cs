using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class GlobleGlowth : MonoBehaviour
{
    public static int GlowthCount;

    public static int GlowthIncreasement = 1;
    public int GlowthStage;
    public static int GlowthRequiredForNextStage = 100;
    public int GlowthMaxStage = 10;
    public static int GlowthIncreasePerTime = 0;
    
    [Header("Glowth Stage Image")]
    public Image GlowthStageImage;
    public Sprite GlowthStageImage_1;
    public Sprite GlowthStageImage_2;
    public Sprite GlowthStageImage_3;
    public Sprite GlowthStageImage_4;
    public Sprite GlowthStageImage_5;

    void Start()
    {
        StartCoroutine(GlowthIncrease());
    }

    void Update()
    {
        if(GlowthCount >= GlowthRequiredForNextStage)
        {
            GlowthStage++;
            GlowthCount = 0;
            GlowthRequiredForNextStage = GlowthRequiredForNextStage * 3;
            UpdateGlowthStageImage();
        }
    }
    IEnumerator GlowthIncrease()
    {
        while (true)
        {
            yield return new WaitForSeconds(1);
            GlowthCount += GlowthIncreasePerTime;
            //Debug.Log("GlowthCount: " + GlowthCount);
        }
    }
    void UpdateGlowthStageImage()
    {
        switch (GlowthStage)
        {
            case 1:
                GlowthStageImage.sprite = GlowthStageImage_1;
                break;
            case 2:
                GlowthStageImage.sprite = GlowthStageImage_2;
                break;
            case 3:
                GlowthStageImage.sprite = GlowthStageImage_3;
                break;
            case 4:
                GlowthStageImage.sprite = GlowthStageImage_4;
                break;
            case 5:
                GlowthStageImage.sprite = GlowthStageImage_5;
                break;
            default:
                GlowthStageImage.sprite = GlowthStageImage_1;
                break;
        }
    }
    
}
