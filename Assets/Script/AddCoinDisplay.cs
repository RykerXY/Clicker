using TMPro;
using UnityEngine;

public class AddCoinDisplay : MonoBehaviour
{
    private TextMeshProUGUI IncreaseCoinDisplay;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        IncreaseCoinDisplay = GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        IncreaseCoinDisplay.text = "+" + GlobleCoin.FormatNumberDouble(GlobleCoin.CoinIncreasement);
    }
}
