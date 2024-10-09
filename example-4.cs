using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    // Public olarak tanımlanan speed değişkeni, Unity editöründen ayarlanabilir
    public float speed = 1.0f;

    // Private olarak tanımlanan speed değişkeni, sadece bu script içinde kullanılabilir
    // private float speed = 1.0f;

    // Start is called before the first frame update
    void Start()
    {
        // Başlangıçta herhangi bir işlem yapılmayabilir
    }

    // Update is called once per frame
    void Update()
    {
        
        // Nesnenin speed değişkeniyle çarpılan hızda ilerlemesi
        transform.position += new Vector3(speed * Time.deltaTime, 0, 0);

    }

}
