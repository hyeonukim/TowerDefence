using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Shop : MonoBehaviour
{
    public List<GameObject> turretList;
    public List<GameObject> missleList;
    public List<GameObject> laserList;
    System.Random rnd = new System.Random();
    public int[] weights = {19, 99, 299, 799, 1599, 6699, 16899, 49999, 100000};
    BuildManager buildManager;
    public int cost = 4;

    private void Start() {
        buildManager = BuildManager.instance;
    }
    
    public void RandomTurret(int rank){
        int val = rnd.Next(1,4);
        if(val == 1){
            buildManager.SelectTurret(turretList[rank]);
            PlayerStats.turret = "Standard Turret";
        }
        else if(val == 2){
            buildManager.SelectTurret(missleList[rank]);
            PlayerStats.turret = "Missle Launcher";
        }
        else{
            buildManager.SelectTurret(laserList[rank]);
            PlayerStats.turret = "Laser Beamer";
        }
    }

    public void PurchaseStandardTurret(){
        if (buildManager.clicked == true){
            return;
        }

        if (PlayerStats.Money < cost){
            return;
        }

        buildManager.counter += 1;
        buildManager.clicked = true;
        PlayerStats.Money -= cost;
        int val = rnd.Next(1, 100000);

        if (val <= weights[0]){
            Debug.Log("SSS+");
            PlayerStats.rank = 0;
            RandomTurret(0);
        }
        else if(val <= weights[1]){
            Debug.Log("SSS");
            PlayerStats.rank = 1;
            RandomTurret(1);
        }
        else if(val <= weights[2]){
            Debug.Log("SS");
            PlayerStats.rank = 2;
            RandomTurret(2);
        }
        else if(val <= weights[3]){
            Debug.Log("S");
            PlayerStats.rank = 3;
            RandomTurret(3);
        }
        else if(val <= weights[4]){
            Debug.Log("A+");
            PlayerStats.rank = 4;
            RandomTurret(4);
        }
        else if(val <= weights[5]){
            Debug.Log("A");
            PlayerStats.rank = 5;
            RandomTurret(5);
        }
        else if(val <= weights[6]){
            Debug.Log("B");
            PlayerStats.rank = 6;
            RandomTurret(6);
        }
        else if(val <= weights[7]){
            Debug.Log("C");
            PlayerStats.rank = 7;
            RandomTurret(7);
        }
        else{
            Debug.Log("D");
            PlayerStats.rank = 8;
            RandomTurret(8);
        }
    }

}
