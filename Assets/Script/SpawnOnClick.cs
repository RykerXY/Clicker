using UnityEngine;

public class SpawnOnClick : MonoBehaviour
{
    public GameObject prefab;
    public RectTransform parentCanvas;

    void Update()
    {

    }

    public void SpawnPrefab()
    {
        Vector2 mousePosition;
        RectTransformUtility.ScreenPointToLocalPointInRectangle(parentCanvas, Input.mousePosition, null, out mousePosition);
        
        GameObject spawnedObject = Instantiate(prefab, parentCanvas);
        spawnedObject.GetComponent<RectTransform>().anchoredPosition = mousePosition;
        
        Destroy(spawnedObject, 1f);
    }
    public void SpawnPrefabAutoClick(RectTransform parentButton)
    {
        Vector2 randomPosition = new Vector2(
            Random.Range(0, (int)parentButton.rect.width),
            Random.Range(0, (int)parentButton.rect.height)
        );

        GameObject spawnedObject = Instantiate(prefab, parentCanvas);
        spawnedObject.GetComponent<RectTransform>().anchoredPosition = randomPosition;

        Destroy(spawnedObject, 1f);
    }

}
