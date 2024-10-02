using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager instance;
    public Text winsP1text;
    public Text winsP2text;
    int p1wins = 0;
    int p2wins = 0;

    private void Awake()
    {
        instance = this;
    }
    // Start is called before the first frame update
    void Start()
    {
        winsP1text.text = "Wins: " + p1wins.ToString();
        winsP2text.text = "Wins: " + p2wins.ToString();
    }

    public void P1win()
    {
        p1wins += 1;
        winsP1text.text = "Wins: " + p1wins.ToString();
    }
    public void P2win()
    {
        p2wins += 1;
        winsP2text.text = "Wins: " + p2wins.ToString();
    }

    // Update is called once per frame
}
