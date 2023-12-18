using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildManager : MonoBehaviour
{
    public static BuildManager instance;
    public int cost;
    public int counter = 0;
    public bool clicked = false;

    private void Awake() {
        if (instance != null){
            return;
        }
        instance = this;
    }
    private GameObject turretToBuild;
    private Node selectedNode;
    
    public bool CanBuild {get {return turretToBuild == null;}}
    public bool HasMoney {get {return PlayerStats.Money >= cost;}}

    public void BuildTurretOn(Node node){

        GameObject turret = (GameObject)Instantiate(turretToBuild, node.GetBuildPosition(), Quaternion.identity);
        node.turret = turret;
        clicked = false;

        Debug.Log(PlayerStats.Money);
    }

    public void SelectNode(Node node){
        selectedNode = node;
        turretToBuild = null;
    }
    public void SelectTurret(GameObject turret){
        turretToBuild = turret;
        selectedNode = null;
    }
}
