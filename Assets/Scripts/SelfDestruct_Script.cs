using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelfDestruct_Script : MonoBehaviour
{
    private void Start()
    {
        StartCoroutine(SelfDestruct());
        StartCoroutine(Tremble());
    }

    IEnumerator SelfDestruct()
    {
        yield return new WaitForSeconds(5.0f);
        Destroy(gameObject);
    }

    IEnumerator Tremble()
    {
        yield return new WaitForSeconds(3f);
        for (int i = 0; i < 10; i++)
        {
            transform.localPosition += new Vector3(0.2f, 0, 0);
            yield return new WaitForSeconds(0.01f);
            transform.localPosition -= new Vector3(0.2f, 0, 0);
            yield return new WaitForSeconds(0.01f);
        }
    }
}
