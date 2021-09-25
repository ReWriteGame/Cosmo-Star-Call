using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Asteroid : MonoBehaviour
{
    public UnityEvent getBulletEvent;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.GetComponent<Destroyer>())
        {
            gameObject.GetComponent<Destroyable>().destroy();
        }

        if(collision.gameObject.GetComponent<Bullet>())
            getBulletEvent?.Invoke();

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.GetComponent<Destroyer>())
        {
            gameObject.GetComponent<Destroyable>().destroy();
        }
    }
}
