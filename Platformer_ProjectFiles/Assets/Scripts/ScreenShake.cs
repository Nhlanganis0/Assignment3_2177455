using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreenShake : MonoBehaviour
{
    [SerializeField] Animator camAnim;

    public void CamShake()
    {
        camAnim.SetTrigger("Shake");
    }
}
