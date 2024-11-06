using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Laser : MonoBehaviour
{
    public float speed = 10f;

    void Update()
    {
        // Laser'i yukarı doğru hareket ettiriyoruz
        transform.Translate(Vector2.up * speed * Time.deltaTime);

        // Ekran dışında kaldığında yok ediyoruz
        if (transform.position.y > 6f)
        {
            Destroy(gameObject);
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        // Düşmana çarptığında yok ediyoruz
        if (other.tag == "Enemy")
        {
            Destroy(other.gameObject);
            Destroy(gameObject);
        }
    }
}
