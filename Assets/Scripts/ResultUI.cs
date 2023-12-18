using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ResultUI : MonoBehaviour
{
    public Text resultText;    
    private string[] ranks = {"SSS+", "SSS", "SS", "S", "A+", "A", "B", "C", "D"};

    private void Update() {
        if( PlayerStats.turret == null){
            return;
        }
        resultText.text = PlayerStats.turret + " (Rank: " + ranks[PlayerStats.rank] + ")";
    }
}
