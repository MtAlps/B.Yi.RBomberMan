using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager instance;
    public Text winsTextP1;
    int winsP1 = 0;
    public Text winsTextP2;
    int winsP2 = 0;

    private void Awake()
    {
        instance = this;
    }
    // Start is called before the first frame update
    void Start()
    {
        winsTextP1.text = "Wins: " + winsP1.ToString();
        winsTextP2.text = "Wins: " + winsP2.ToString();
    }

    public void P1Win() {
        winsP1 += 1;
        winsTextP1.text = "Wins: " + winsP1.ToString();
    }

    public void P2Win() {
        winsP2 += 1;
        winsTextP2.text = "Wins: " + winsP2.ToString();
    }
}
