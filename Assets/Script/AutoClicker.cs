using UnityEngine;

public class AutoClicker : MonoBehaviour
{
    public bool autoClick = false;
    public RectTransform parentButton;
    public float clickInterval = 1f;
    private float timeSinceLastClick = 0f;
    public SpawnOnClick spawnOnClickScript;

    void Update()
    {
        if (autoClick)
        {
            timeSinceLastClick += Time.deltaTime;

            if (timeSinceLastClick >= clickInterval)
            {
                timeSinceLastClick = 0f;

                AutoClickAndSpawn();
            }
        }
    }

    private void AutoClickAndSpawn()
    {
        spawnOnClickScript.SpawnPrefabAutoClick(parentButton);
        
        GlobleCoin.CoinCount += (long)GlobleCoin.CoinIncreasement;
    }
    public void ToggleAutoClick()
    {
        autoClick = !autoClick;
    }
}
