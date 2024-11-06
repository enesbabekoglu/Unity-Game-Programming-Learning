using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 5f;
    private Rigidbody2D rb;
    private float horizontalInput;
    private float verticalInput;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        // Klavye girdilerini alıyoruz
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");
    }

    void FixedUpdate()
    {
        // Hareket vektörünü oluşturuyoruz
        Vector2 movement = new Vector2(horizontalInput, verticalInput) * speed;
        // Nesneyi hareket ettiriyoruz
        rb.velocity = movement;
    }
}
