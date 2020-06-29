using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet2 : MonoBehaviour
{
public float speed = 10f;
public float DamageAmount = 10f;

private Rigidbody2D rb;

private void Start()
{
    rb = GetComponent<Rigidbody2D>();
    rb.velocity = Vector2.down * speed;
}

private void OnCollisionEnter2D(Collision2D collision)
{
    if (collision.gameObject.CompareTag("Player"))
    {
        Player player = collision.gameObject.GetComponent<Player>();

        if (player != null)
        {
            player.Damage(DamageAmount);
            Destroy(this.gameObject);
        }
    }
}
}
