using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    public Text levelText;

    private void OnEnable() {
        levelText.text = PlayerStats.level.ToString();
    }

    public void Retry(){                
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
