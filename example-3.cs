using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // Başlangıçta herhangi bir işlem yapılmayabilir
    }

    // Update is called once per frame
    void Update()
    {
        
        // Nesnenin saniyede bir birim ilerlemesi için zamanın normalizasyonunu kullanıyoruz
        transform.position += new Vector3(1 * Time.deltaTime, 0, 0);

    }

}
