using System;
using TMPro;
using UnityEngine;

public class GlobleCoin : MonoBehaviour
{
    public static double CoinCount = 0;
    public static double CoinIncreasement = 1;
    //public static long CoinIncreasePerTime = 1;
    public TextMeshProUGUI CoinDisplay; 
    void Update()
    {
        CoinDisplay.text = "Coin: " + FormatNumberDouble(CoinCount);
    }

    public static string FormatNumber(long num)
    {
        if (num >= 1_000_000_000_000_000) return (num / 1_000_000_000_000_000f).ToString("0.##") + "Q"; // Quadrillion
        if (num >= 1_000_000_000_000) return (num / 1_000_000_000_000f).ToString("0.##") + "T"; // Trillion
        if (num >= 1_000_000_000) return (num / 1_000_000_000f).ToString("0.##") + "B"; // Billion
        if (num >= 1_000_000) return (num / 1_000_000f).ToString("0.##") + "M"; // Million
        if (num >= 1_000) return (num / 1_000f).ToString("0.##") + "K"; // Thousand

        return num.ToString("N0"); // ปกติแสดงเป็นตัวเลขเต็ม
    }
    public static string FormatNumberDouble(Double num)
    {
        if (num >= 1_000_000_000_000_000) return (num / 1_000_000_000_000_000f).ToString("0.##") + "Q"; // Quadrillion
        if (num >= 1_000_000_000_000) return (num / 1_000_000_000_000f).ToString("0.##") + "T"; // Trillion
        if (num >= 1_000_000_000) return (num / 1_000_000_000f).ToString("0.##") + "B"; // Billion
        if (num >= 1_000_000) return (num / 1_000_000f).ToString("0.##") + "M"; // Million
        if (num >= 1_000) return (num / 1_000f).ToString("0.##") + "K"; // Thousand

        return num.ToString("N0"); // ปกติแสดงเป็นตัวเลขเต็ม
    }
}
