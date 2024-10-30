using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject enemyPrefab; // Üretilecek düşman prefab'ı
    public Transform enemyContainer; // Düşmanları tutacak parent nesne

    private bool spawnActive = true; // Spawn işlemini kontrol eden değişken

    void Start()
    {
        StartCoroutine(SpawnEnemyRoutine());
    }

    IEnumerator SpawnEnemyRoutine()
    {
        while (spawnActive)
        {
            yield return new WaitForSeconds(5f);
            GameObject newEnemy = Instantiate(enemyPrefab, transform.position, Quaternion.identity);
            newEnemy.transform.parent = enemyContainer; // Düşmanı parent nesneye ata
        }
    }

    public void StopSpawning()
    {
        spawnActive = false;
    }
    
}
