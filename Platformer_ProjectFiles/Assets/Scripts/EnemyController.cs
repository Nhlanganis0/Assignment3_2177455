using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public int speed;
    public int speed_1;
    public bool _Moving = true;
    public float Moving_Speed;

    void Update()
    {
        if (_Moving == true)
        {
            transform.Translate(speed * Time.deltaTime * Moving_Speed, 0, 0);
        }
        else
        {
            transform.Translate(speed_1 * Time.deltaTime * Moving_Speed, 0, 0);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Patroll"))
        {
            if (_Moving)
            {
                _Moving = false;
            }
            else
            {
                _Moving = true;
            }
        }
    }
}
