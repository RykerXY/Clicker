using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class GlowthBar : MonoBehaviour
{
    private Slider slider;
    public TextMeshProUGUI GlowthCountDisplay;
    void Start()
    {
        slider = GetComponent<Slider>();
    }

    void Update()
    {
        slider.value = (float)GlobleGlowth.GlowthCount;
        slider.maxValue = (float)GlobleGlowth.GlowthRequiredForNextStage;
        GlowthCountDisplay.text = GlobleGlowth.GlowthCount + "/" + GlobleCoin.FormatNumberDouble(GlobleGlowth.GlowthRequiredForNextStage);
    }
}
