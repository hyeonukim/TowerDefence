using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Node : MonoBehaviour
{
    public Color hoverColor;
    [Header ("Optional")] 
    public GameObject turret;
    public Vector3 positionOffset;
    private Renderer rend;
    private Color startColor;
    BuildManager buildManager;

    private void Start() {
        rend = GetComponent<Renderer>();
        startColor = rend.material.color;

        buildManager = BuildManager.instance;
    }

    public Vector3 GetBuildPosition(){
        return transform.position + positionOffset;
    }

    private void OnMouseDown() {
        if (EventSystem.current.IsPointerOverGameObject()){
            return;
        }

        if (turret != null){
            buildManager.SelectNode(this);
            return;
        }

        if (buildManager.CanBuild){
            return;
        }
        if (buildManager.counter == 0){
            return;
        }

        buildManager.BuildTurretOn(this);
        buildManager.counter--;
    }

    private void OnMouseEnter() {
        if (EventSystem.current.IsPointerOverGameObject()){
            return;
        }

        if (buildManager.CanBuild){
            return;
        }

        if (buildManager.counter == 0){
            return;
        }
        rend.material.color = hoverColor;
    }

    private void OnMouseExit() {
        rend.material.color = startColor;
    }
}
