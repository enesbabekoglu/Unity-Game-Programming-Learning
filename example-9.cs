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
}
