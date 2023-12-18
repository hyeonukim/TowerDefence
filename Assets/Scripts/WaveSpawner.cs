using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WaveSpawner : MonoBehaviour
{
    public Transform enemyPrefab;
    public Transform spawnPoint;
    public float timeBetweenWaves = 180f;
    private float countdown = 10f;
    public Text waveCountdownText;
    private int waveIndex = 100;
    private int bossCount;

    private void Update() {
        if (countdown <= 0f){
            StartCoroutine(SpawnWave());
            countdown = timeBetweenWaves;
            PlayerStats.level++;
        }

        countdown -= Time.deltaTime;
        countdown = Mathf.Clamp(countdown, 0f, Mathf.Infinity);

        waveCountdownText.text = "Next Wave in: " + string.Format("{0:00:00}", countdown) + "\nLevel: " + PlayerStats.level;
    }

    IEnumerator SpawnWave(){

        if (PlayerStats.level % 2 == 0 && PlayerStats.level > 0){
            waveIndex += 10;
        }

        for (int i = 0; i < waveIndex; i++){
            SpawnEnemy();
            yield return new WaitForSeconds(0.1f);
        }
    }

    void SpawnEnemy(){
        Instantiate(enemyPrefab, spawnPoint.position, spawnPoint.rotation);
        PlayerStats.enemyCount++;
    }
}

