using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;  // UI için gerekli

public class Player : MonoBehaviour
{
    public int health = 3; // Oyuncunun başlangıç canı
    public Text healthText; // UI'da can göstergesi

    void Start()
    {
        UpdateHealthUI(); // Oyuncunun canını başlangıçta UI'da güncelle
    }

    // Hasar alma işlemi
    public void TakeDamage()
    {
        health--; // Her hasar aldığında canı bir azalt
        UpdateHealthUI(); // Hasardan sonra UI'yi güncelle

        if (health <= 0)
        {
            Debug.Log("Oyun Bitti!");
            // Burada oyun sonu işlemlerini gerçekleştirebilirsin
        }
    }

    // UI'daki can göstergesini güncelleyen fonksiyon
    void UpdateHealthUI()
    {
        if (healthText != null)
        {
            healthText.text = "Health: " + health; // UI'daki can değerini güncelle
        }
    }
}
