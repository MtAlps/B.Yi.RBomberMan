using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;


public class GameManager : MonoBehaviour
{

    public static GameManager Instance { get ; private set; }
    public GameObject[] players;
    public GameObject winScreen;
    public TextMeshProUGUI winText;
    private GameObject player1;
    private GameObject player2;

    private void Awake()
    {
        if (Instance != null) {
        DestroyImmediate(gameObject);
        } else {
        Instance = this;
    }
    }
    private void OnDestroy()
    {
        if (Instance == this) {
            Instance = null;
        }
    }
    private void Start()
    {
        player1 = players[0];
        player2 = players[1];

        winScreen.SetActive(false);
    }
    public void CheckWinState()
    {
        int aliveCount = 0;

        foreach (GameObject player in players)
        {
            if (player.activeSelf) {
                aliveCount++;
            }
        }

        if (aliveCount <= 1) {
            if (player1.activeSelf)
            {
                winScreen.SetActive(true);
                ScoreManager.instance.P1win();
                winText.text = "Player 1 wins!";
            }
            else if(player2.activeSelf) 
            {
                winScreen.SetActive(true);
                ScoreManager.instance.P2win();
                winText.text = "Player 2 wins!";
            } 
        }
    }

}
