using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[RequireComponent(typeof(Collider2D))]
public class LaserGun : MonoBehaviour
{
    public Transform directionThrow;

    public UnityEvent laserShotEnent;

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
        laserShotEnent?.Invoke();
    }
}
