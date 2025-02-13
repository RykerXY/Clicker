using UnityEngine;
using UnityEngine.UI;

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
}
