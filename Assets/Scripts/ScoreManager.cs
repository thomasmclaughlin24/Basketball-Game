using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    internal int player1score = 0;
    internal int player2score = 0;

    public GameObject gameManager = null;
    private GameManager gm = null;
    // Start is called before the first frame update
    void Start()
    {
        gm = gameManager.GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
	    if (gm.whoseTurn == 1) {
            player1score = player1score + 1;
        }
        else {
            player2score = player2score + 1;
        }
    }
}
