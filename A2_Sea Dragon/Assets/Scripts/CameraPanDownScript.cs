using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraPanDownScript : MonoBehaviour
{
    [SerializeField] public GameObject startObject;
    [SerializeField] public GameObject targetObject;
    [SerializeField] public float duration = 1f;

    private void Start()
    {
        StartCoroutine(PanToTarget());
    }

    IEnumerator PanToTarget()
    {
        Vector3 startPosition = startObject.transform.position;
        Vector3 endPosition = targetObject.transform.position;

        float elapsedTime = 0;

        while (elapsedTime < duration)
        {
            float t = elapsedTime / duration;
            t = t * t * (3f - 2f * t);

            transform.position = Vector3.Lerp(startPosition, endPosition, t);

            elapsedTime += Time.deltaTime;
            yield return null;
        }

        transform.position = endPosition;
    }
}
