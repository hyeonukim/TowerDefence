using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Enemy : MonoBehaviour
{
    public float speed = 20f;

    public float startHealth = 50;
    private float health;
    public int value = 5;
    public GameObject deathEffect;

    [Header("Unity Stuff")]
    public Image healthBar;

    private void Start() {

        if (PlayerStats.level % 2 == 0 && PlayerStats.level > 0){
            startHealth += 50;
            speed += 2f;
        }
        health = startHealth;
    }
    public void TakeDamage(float amonunt){
        health -= amonunt;
        healthBar.fillAmount = health / startHealth;
        if (health <= 0){
            Die();
        }
    }

    void Die(){
        Destroy(gameObject);
        PlayerStats.enemyKilled += 1;
        
        if (PlayerStats.enemyKilled % 8 == 0){
            PlayerStats.Money += value;
        }
        GameObject effect = (GameObject) Instantiate(deathEffect, transform.position, Quaternion.identity);
        Destroy(effect, 5f);

        PlayerStats.enemyCount -= 1;
    }
}
