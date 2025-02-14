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
        slider.value = GlobleGlowth.GlowthCount;
        slider.maxValue = GlobleGlowth.GlowthRequiredForNextStage;
        GlowthCountDisplay.text =GlobleGlowth.GlowthCount + "/" + GlobleGlowth.GlowthRequiredForNextStage + "GP";
    }
}
