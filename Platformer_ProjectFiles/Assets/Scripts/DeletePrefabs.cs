using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeletePrefabs : MonoBehaviour
{
    private float secondsToDestroy = 30f;
    void Start()
    {
        StartCoroutine(DestroySelf());
    }

    IEnumerator DestroySelf()
    {
        yield return new WaitForSeconds(secondsToDestroy);
        Destroy(gameObject);
    }
}
