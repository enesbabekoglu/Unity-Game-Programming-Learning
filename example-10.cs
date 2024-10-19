using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Enemy : MonoBehaviour
{
    public float speed = 2f;

    void Update()
    {
        // Enemy'i aşağı doğru hareket ettir
        transform.Translate(Vector2.down * speed * Time.deltaTime);

        // Ekranın altına indiğinde yok et
        if (transform.position.y < -Camera.main.orthographicSize)
        {
            Destroy(gameObject);
        }
    }

    // Çarpışmaları algılayan fonksiyon
    void OnTriggerEnter2D(Collider2D collision)
    {
        // Eğer enemy, Player'a çarparsa
        if (collision.CompareTag("Player"))
        {
            // Oyuncuya hasar ver
            collision.GetComponent<Player>().TakeDamage();

            // Enemy objesini yok et
            Destroy(gameObject);
        }

        // Eğer enemy, Lazer'e çarparsa
        else if (collision.CompareTag("Laser"))
        {
            // Lazer objesini yok et
            Destroy(collision.gameObject);

            // Enemy objesini yok et
            Destroy(gameObject);
        }
    }
}
