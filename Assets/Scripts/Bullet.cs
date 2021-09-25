using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.GetComponent<Asteroid>())
        {
            collision.GetComponent<Destroyable>().destroy();
            gameObject.GetComponent<Destroyable>().destroy();
        }
    }
}
