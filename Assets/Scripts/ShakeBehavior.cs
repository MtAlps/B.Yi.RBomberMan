using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShakeBehavior : MonoBehaviour
{
    public bool start = false;
    public AnimationCurve curve;
    public float duration;

    void Update()
    {
        if (start)
        {
            start = false;
            StartCoroutine(Shaking());
        }
    }

    IEnumerator Shaking()
    {
        Vector3 start_pos = transform.position;
        float elapsed_time = 0f;

        while (elapsed_time < duration)
        {
            elapsed_time += Time.deltaTime;
            float strength = curve.Evaluate(elapsed_time / duration);
            transform.position = start_pos + Random.insideUnitSphere * strength;
            yield return null;
        }
        transform.position = start_pos;
    }




}
      

