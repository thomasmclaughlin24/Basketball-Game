using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StartButton : MonoBehaviour
{
    public Button startButton;
    public Image startImage;
    public GameObject Player1Name;
    public GameObject Player2Name;
    public Button okButton;

    public GameObject gameManager = null;
    private GameManager gm = null;

    // Start is called before the first frame update
    void Start()
    {
        Button btn = startButton.GetComponent<Button>();
        btn.onClick.AddListener(picknames);
        gm = gameManager.GetComponent<GameManager>();
    }

    // Update is called once per frame
    void picknames()
    {
        //gm.gamestarted = true;
        startButton.gameObject.SetActive(false);
        //startImage.gameObject.SetActive(false);
        Player1Name.gameObject.SetActive(true);
        Player2Name.gameObject.SetActive(true);
        okButton.gameObject.SetActive(true);
    }
}
