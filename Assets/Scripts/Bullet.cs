using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField] private float force = 1;

    public float Force { get => force; private set => force = value; }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.GetComponent<Asteroid>())
        {
            collision.GetComponent<Destroyable>().destroy(3f);
            gameObject.GetComponent<Destroyable>().destroy();
        }

        if (collision.gameObject.GetComponent<Destroyer>())
        {
            gameObject.GetComponent<Destroyable>().destroy();
        }
    }
}
