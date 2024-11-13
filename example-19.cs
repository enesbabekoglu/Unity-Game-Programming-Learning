using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{

    public GameObject enemyPrefab; // Düşman prefab'i
    public GameObject bonusPrefab; // Bonus prefab'i
    public float spawnInterval = 2f; // Spawn olma aralığı
    public float bonusSpawnChance = 0.1f; // Bonus gelme ihtimali (%10)
    public float minScale = 0.5f; // Minimum boyut
    public float maxScale = 1.5f; // Maksimum boyut
    public float minRotationSpeed = 10f; // Minimum dönüş hızı
    public float maxRotationSpeed = 50f; // Maksimum dönüş hızı

    void Start()
    {
        // Düşmanları ve bonusları belirli bir aralıkla spawn etmeye başla
        InvokeRepeating("SpawnEnemyOrBonus", 1f, spawnInterval);
    }

    void SpawnEnemyOrBonus()
    {
        float chance = Random.Range(0f, 1f); // 0-1 arası rastgele sayı

        // %10 ihtimalle bonus spawn et, diğer durumda düşman spawn et
        if (chance < bonusSpawnChance)
        {
            SpawnBonus();
        }
        else
        {
            SpawnEnemy();
        }
    }

    void SpawnBonus()
    {
        float xPosition = Random.Range(-8f, 8f);
        Vector3 spawnPosition = new Vector3(xPosition, 6f, 0f);
        GameObject newBonus = Instantiate(bonusPrefab, spawnPosition, Quaternion.identity);

        // Bonus dönüş hızını rastgele ayarla (tüm bonuslar aynı şekilde hareket edebilir)
        float rotationSpeed = Random.Range(minRotationSpeed, maxRotationSpeed);
        newBonus.GetComponent<Bonus>().rotationSpeed = rotationSpeed;
    }

    void SpawnEnemy()
    {
        float xPosition = Random.Range(-8f, 8f);
        Vector3 spawnPosition = new Vector3(xPosition, 6f, 0f);
        GameObject newEnemy = Instantiate(enemyPrefab, spawnPosition, Quaternion.identity);

        float randomScale = Random.Range(minScale, maxScale);
        newEnemy.transform.localScale = new Vector3(randomScale, randomScale, 1);

        float rotationSpeed = Random.Range(minRotationSpeed, maxRotationSpeed);
        newEnemy.GetComponent<Enemy>().rotationSpeed = rotationSpeed;
    }

}
