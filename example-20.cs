using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed = 5f; // Hareket hızı
    private Rigidbody2D rb;
    private float horizontalInput;

    public Transform laserSpawnPoint; // Lazerin çıkış noktası
    public GameObject laserPrefab;    // Normal lazer prefab'i
    public GameObject tripleLaserPrefab; // Üçlü lazer prefab'i
    public float laserSpeed = 10f;    // Lazerin hareket hızı

    private bool isTripleShotActive = false; // Üçlü atış durumu
    private float tripleShotDuration = 10f; // Üçlü atış süresi

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        // Klavye girdilerini al
        horizontalInput = Input.GetAxis("Horizontal");

        // Lazer ateşleme kontrolü
        if (Input.GetKeyDown(KeyCode.Space))
        {
            FireLaser();
        }
    }

    void FixedUpdate()
    {
        // Player hareketi
        Vector2 movement = new Vector2(horizontalInput, 0) * speed;
        rb.velocity = movement;
    }

    void FireLaser()
    {
        if (isTripleShotActive)
        {
            // Üç lazeri farklı pozisyonlarda spawn et
            Vector3 leftLaserPosition = laserSpawnPoint.position + new Vector3(-0.5f, 0, 0);
            Vector3 rightLaserPosition = laserSpawnPoint.position + new Vector3(0.5f, 0, 0);

            Instantiate(laserPrefab, laserSpawnPoint.position, Quaternion.identity); // Orta lazer
            Instantiate(laserPrefab, leftLaserPosition, Quaternion.identity); // Sol lazer
            Instantiate(laserPrefab, rightLaserPosition, Quaternion.identity); // Sağ lazer
        }
        else
        {
            // Normal lazer
            Instantiate(laserPrefab, laserSpawnPoint.position, Quaternion.identity);
        }
    }

    public void ActivateTripleShot()
    {
        isTripleShotActive = true;
        StartCoroutine(TripleShotTimer());
    }

    private IEnumerator TripleShotTimer()
    {
        yield return new WaitForSeconds(tripleShotDuration); // 10 saniye bekle
        isTripleShotActive = false; // Bonus etkisini kapat
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("TripleShotBonus")) // Bonus tag'i kontrol et
        {
            ActivateTripleShot();
            Destroy(collision.gameObject); // Bonus nesnesini yok et
        }
    }

}
