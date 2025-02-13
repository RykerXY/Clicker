using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class BounceImage : MonoBehaviour
{
    public RectTransform imageTransform;
    public float bounceScale = 1.2f;
    public float bounceDuration = 0.2f;

    private Vector3 originalScale;

    void Start()
    {
        originalScale = imageTransform.localScale;
    }

    public void Bounce() => StartCoroutine(BounceEffect());
    IEnumerator BounceEffect()
    {
        imageTransform.localScale = originalScale * bounceScale;
        yield return new WaitForSeconds(bounceDuration);
        imageTransform.localScale = originalScale;
    }
}
