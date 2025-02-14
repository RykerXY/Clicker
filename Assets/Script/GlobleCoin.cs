using TMPro;
using UnityEngine;

public class GlobleCoin : MonoBehaviour
{
    public static int CoinCount;
    public static int CoinIncreasement = 1;
    public TextMeshProUGUI CoinDisplay; 
    // Update is called once per frame
    void Update()
    {
        CoinDisplay.text = "Coin: " + CoinCount;
    }

}
