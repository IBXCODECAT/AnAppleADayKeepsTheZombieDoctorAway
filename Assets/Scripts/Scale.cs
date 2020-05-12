using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scale : MonoBehaviour
{
    public float startingScale;
    public float endingScale;
    public float scaleSpeed = 2;

    private void OnEnable()
    {
        transform.localScale = Vector3.one * startingScale;
        StartCoroutine(StartScale());
    }

    IEnumerator StartScale()
    {
        yield return new WaitUntil(() => Scaling());
        gameObject.SetActive(false);
    }

    bool Scaling()
    {
        transform.localScale = Vector3.MoveTowards(transform.localScale, endingScale * Vector3.one, scaleSpeed * Time.deltaTime);
        return Vector3.Distance(transform.localScale, endingScale * Vector3.one) < .1f;
    }

}
