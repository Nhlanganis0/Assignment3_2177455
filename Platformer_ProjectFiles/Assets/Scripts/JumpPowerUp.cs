using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpPowerUp : MonoBehaviour
{
    [SerializeField] private int destroyTime;
    
    void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log(collision.name);
        PlayerController player = collision.GetComponent<PlayerController>();
        if(player != null)
        {
            player.AddJump();
        }
        Destroy(gameObject, destroyTime);
    }
}
