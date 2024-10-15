using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserController : MonoBehaviour
{
    public GameObject laserPrefab; // Laser prefab'ini eklemek için
    public Transform firePoint; // Lazerin atılacağı nokta
    public float fireRate = 0.5f; // Atışlar arasındaki bekleme süresi
    private float nextFire = 0f; // Bir sonraki atışın zamanı

    void Update()
    {
        // Eğer "Space" tuşuna basılırsa ve bekleme süresi dolmuşsa lazer ateşlenir
        if (Input.GetKey(KeyCode.Space) && Time.time > nextFire)
        {
            nextFire = Time.time + fireRate; // Bekleme süresi hesaplanır ve atış zamanı ayarlanır
            FireLaser(); // Lazer ateşleme fonksiyonu çağrılır
        }
    }

    void FireLaser()
    {
        // Lazer prefab'ini belirlenen konumda oluşturuyoruz
        GameObject laser = Instantiate(laserPrefab, firePoint.position, firePoint.rotation);

        // Lazer için hareket komutunu verecek bir script'i ekliyoruz
        laser.AddComponent<LaserMovement>();

        // Lazer ekrandan çıktıktan sonra yok edilecek
        Destroy(laser, 5f); // Lazer 5 saniye sonra yok ediliyor
    }
}

public class LaserMovement : MonoBehaviour
{
    public float speed = 1f; // Lazerin hareket hızı

    void Update()
    {
        // Lazer her saniye bir birim yukarı doğru hareket eder, sadece Y ekseninde hareket sağlanır
        transform.position += new Vector3(0, speed * Time.deltaTime, 0);
    }
}
