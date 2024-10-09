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
        
        // Dikey eksendeki hareket girdi değerini alıyoruz (W/S veya Yukarı/Aşağı tuşları)
        float verticalInput = Input.GetAxis("Vertical");

        // Nesnenin dikey eksende ilerlemesini sağlıyoruz
        transform.position += new Vector3(0, verticalInput * speed * Time.deltaTime, 0);

    }

}
