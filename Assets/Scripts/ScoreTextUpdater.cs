using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreTextUpdater : MonoBehaviour
{
    public string playerName = "Player 1";
    public GameObject scorer = null;
    public int playerNumber = 1;
    private ScoreManager scoreManager = null;

    public GameObject gameManager = null;
    private GameManager gm = null;

    // Start is called before the first frame update
    void Start()
    {
        scoreManager = scorer.GetComponent<ScoreManager>();
        gm = gameManager.GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        if (playerNumber == 1) {
            GetComponent<TextMeshPro>().text = gm.Player1Name + ": " + scoreManager.player1score;
        }
        else {
            GetComponent<TextMeshPro>().text = gm.Player2Name + ": " + scoreManager.player2score;
        }
    }
}
