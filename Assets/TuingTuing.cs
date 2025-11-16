using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TuingTuing : MonoBehaviour
{
    public float bounceSpeed = 3f;
    public float bounceHeight = 0.1f;
    public float squishAmount = 0.05f;
    public float squishSpeed = 8f;

    public float headTurnSpeed = 1.5f;
    public float headTurnAngle = 20f;

    public float jumpHeight = 1.5f;
    public float jumpDuration = 0.6f;

    private Vector3 originalScale;
    private Vector3 originalPosition;
    private Vector3 originalEulerRotation;

    private bool startedBounce = false;

    void Start()
    {
        originalScale = transform.localScale;
        originalPosition = transform.position;
        originalEulerRotation = transform.eulerAngles;

        StartCoroutine(LoncatAwal());
    }

    void Update()
    {
        if (!startedBounce) return;

        float time = Time.time;

        // 1. Tuing-tuing naik turun
        float yOffset = Mathf.Sin(time * bounceSpeed) * bounceHeight;
        transform.position = originalPosition + new Vector3(0, yOffset, 0);

        // 2. Squash-Stretch lucu
        float stretch = Mathf.Sin(time * bounceSpeed);
        float scaleY = 1 - (stretch * squishAmount);
        float scaleX = 1 + (stretch * squishAmount * 0.5f);

        scaleX = Mathf.Clamp(scaleX, 0.95f, 1.05f);
        scaleY = Mathf.Clamp(scaleY, 0.95f, 1.05f);

        Vector3 newScale = new Vector3(
            originalScale.x * scaleX,
            originalScale.y * scaleY,
            originalScale.z * scaleX
        );
        transform.localScale = Vector3.Lerp(transform.localScale, newScale, Time.deltaTime * squishSpeed);

        // 3. Noleh kanan-kiri
        Vector3 newEuler = originalEulerRotation;
        newEuler.y += Mathf.Sin(time * headTurnSpeed) * headTurnAngle;
        transform.rotation = Quaternion.Euler(newEuler);
    }

    IEnumerator LoncatAwal()
    {
        float timer = 0f;
        Vector3 start = originalPosition;
        Vector3 peak = originalPosition + Vector3.up * jumpHeight;

        // Naik
        while (timer < jumpDuration / 2f)
        {
            transform.position = Vector3.Lerp(start, peak, timer / (jumpDuration / 2f));
            timer += Time.deltaTime;
            yield return null;
        }

        timer = 0f;
        // Turun
        while (timer < jumpDuration / 2f)
        {
            transform.position = Vector3.Lerp(peak, originalPosition, timer / (jumpDuration / 2f));
            timer += Time.deltaTime;
            yield return null;
        }

        transform.position = originalPosition;
        startedBounce = true;
    }
}
