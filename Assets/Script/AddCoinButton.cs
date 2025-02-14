using UnityEngine;

public class AddCoinButton : MonoBehaviour
{
    public void AddCoin()
    {
        GlobleCoin.CoinCount += GlobleCoin.CoinIncreasement;
    }
}
