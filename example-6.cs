using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    // Public olarak tanımlanan speed değişkeni, hareket hızını ayarlamak için kullanılır
    public float speed = 5.0f;

    // Start is called before the first frame update
    void Start()
    {
        // Başlangıçta herhangi bir işlem yapılmayabilir
    }

    // Update is called once per frame
    void Update()
    {

        // Dikey eksen (W/S veya Yukarı/Aşağı tuşları) için girdi değeri
        float verticalInput = Input.GetAxis("Vertical");

        // Yatay eksen (A/D veya Sol/Sağ tuşları) için girdi değeri
        float horizontalInput = Input.GetAxis("Horizontal");

        // Nesnenin yatay ve dikey eksende hareketini sağlıyoruz
        transform.position += new Vector3(horizontalInput * speed * Time.deltaTime, verticalInput * speed * Time.deltaTime, 0);
        
    }

}
