using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public int whoseTurn = 1;
    public bool gamestarted = false;
    internal string Player1Name = "Player 1";
    internal string Player2Name = "Player 2";
    //public GameObject scorer = null;
    //private ScoreManager scoreManager = null;
    // Start is called before the first frame update
    void Start()
    {
    //    scoreManager = scorer.GetComponent<ScoreManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
