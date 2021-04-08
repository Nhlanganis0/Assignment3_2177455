using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TutorialTrigger : MonoBehaviour
{
    [SerializeField] private GameObject startButton;

    private void Start()
    {
        startButton.SetActive(false);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            StartCoroutine(StartPlay());
        }
    }

    IEnumerator StartPlay()
    {
        yield return new WaitForSeconds(2);
        startButton.SetActive(true);
    }
}
