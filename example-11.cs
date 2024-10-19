using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public int health = 3; // Oyuncunun başlangıç canı

    // Hasar alma işlemi
    public void TakeDamage()
    {
        health--; // Her hasar aldığında canı bir azalt
        Debug.Log("Oyuncu hasar aldı! Kalan can: " + health);

        if (health <= 0)
        {
            Debug.Log("Oyun Bitti!");
            // Burada oyun sonu işlemlerini gerçekleştirebilirsin
        }
    }
}
