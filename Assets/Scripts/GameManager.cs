using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{    
    public Text enemiesCountText;
    public Text killedCountText;
    private int safeCount = 99;
    private int warnCount = 130;
    private int dangerCount = 150;
    private int deathCount = 200;
    public static bool gameEnded;
    public GameObject gameOverUI;

    private void Start() {
        gameEnded = false;
    }

    private void Update() {
        if (gameEnded){
            return;
        }

        enemiesCountText.text = "Number of Enemies: " + PlayerStats.enemyCount;
        killedCountText.text = "Kills: " + PlayerStats.enemyKilled;

        if (Input.GetKey("e")){
            EndGame();
        }
        
        if (PlayerStats.enemyCount <= safeCount){
            enemiesCountText.color = Color.white;
        }
        else if(PlayerStats.enemyCount <= warnCount){
            enemiesCountText.color = Color.yellow;
        }
        else if(PlayerStats.enemyCount <= dangerCount){
            enemiesCountText.color = Color.red;
        }
        else if(PlayerStats.enemyCount >= deathCount){
            EndGame();
        }
    }

    private void EndGame(){
        gameEnded = true;
        gameOverUI.SetActive(true);
    }
}
