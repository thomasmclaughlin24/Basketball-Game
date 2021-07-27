using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class WhosTurn : MonoBehaviour
{
    public GameManager turncontrol;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        string TurnName = "";
        if (turncontrol.whoseTurn == 1)
        {
            TurnName = turncontrol.Player1Name;

        }
        else
        {
            TurnName = turncontrol.Player2Name;
        }
        GetComponent<TextMeshPro>().text = TurnName + "'s turn.";
    }
}
