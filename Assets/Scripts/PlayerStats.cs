using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStats : MonoBehaviour
{
    public static int Money;
    public int startMoney = 10;
    public static string turret;
    public static int rank;
    public static int level;
    public int startLevel = 0;
    public static int enemyCount = 0;
    public static int enemyKilled = 0;
    
    private void Start() {
        Money = startMoney;
        level = startLevel;
    }
}
