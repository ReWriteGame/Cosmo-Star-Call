using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Collider2D))]
public class LaserGun : MonoBehaviour
{
    public Transform directionThrow;

    [SerializeField] private Bullet currentBullet;
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.GetComponent<Bullet>())
        {
            currentBullet = collision.GetComponent<Bullet>();
            ThrowKnife();
        }
    }


    public void ThrowKnife()
    {
        currentBullet.gameObject.GetComponent<Rigidbody2D>().AddForce((directionThrow.position - transform.position).normalized * currentBullet.Force, ForceMode2D.Impulse);
    }
}
