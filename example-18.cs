using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bonus : MonoBehaviour
{
    public float speed = 2f; // Aşağı doğru hareket hızı
    public float rotationSpeed = 20f; // Kendi ekseninde dönme hızı

    void Update()
    {
        // Aşağı doğru hareket
        transform.Translate(Vector3.down * speed * Time.deltaTime, Space.World);

        // Kendi ekseninde dönme
        transform.Rotate(Vector3.forward * rotationSpeed * Time.deltaTime);

        // Eğer ekranın altına geçtiyse nesneyi yok et
        if (transform.position.y < -6f) // Ekranın alt sınırı
        {
            Destroy(gameObject);
        }
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        // Eğer lazerle çarpışırsa
        if (collision.CompareTag("Laser"))
        {
            // Oyuncu script'ine eriş ve üçlü bonusu aktif et
            FindObjectOfType<Player>().ActivateTripleShot();

            // Lazer ve bonus nesnesini yok et
            Destroy(collision.gameObject);
            Destroy(gameObject);
        }
    }
    
}
