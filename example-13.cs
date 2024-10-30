using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject enemyPrefab; // Üretilecek düşman prefab'ı
    private bool spawnActive = true; // Spawn işlemini kontrol eden değişken

    void Start()
    {
        StartCoroutine(SpawnEnemyRoutine());
    }

    IEnumerator SpawnEnemyRoutine()
    {
        while (spawnActive)
        {
            yield return new WaitForSeconds(5f); // 5 saniye bekle
            Instantiate(enemyPrefab, transform.position, Quaternion.identity);
        }
    }

    public void StopSpawning()
    {
        spawnActive = false;
    }
    
}
