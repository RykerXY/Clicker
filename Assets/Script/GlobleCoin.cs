using TMPro;
using UnityEngine;

public class GlobleCoin : MonoBehaviour
{
    public static int CoinCount;
    public static int Increasement = 1;
    public int InternalCoin = 0;
    public TextMeshProUGUI CoinDisplay; 
    // Update is called once per frame
    void Update()
    {
        InternalCoin = CoinCount;
        CoinDisplay.text = "Coin: " + InternalCoin;
    }
}
