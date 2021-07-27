using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OkButtonScript : MonoBehaviour
{
    public Image startImage;
    public Button okButton;
    public InputField player1NameInput;
    public InputField player2NameInput;
    public GameObject title;
    public GameObject gameManager = null;
    private GameManager gm = null;

    // Start is called before the first frame update
    void Start()
    {
        Button btn = okButton.GetComponent<Button>();
        btn.onClick.AddListener(startgame);
        gm = gameManager.GetComponent<GameManager>();
    }

    // Update is called once per frame
    void startgame()
    {
        gm.gamestarted = true;
        gm.Player1Name = player1NameInput.text;
        gm.Player2Name = player2NameInput.text;
        startImage.gameObject.SetActive(false);
        player1NameInput.gameObject.SetActive(false);
        player2NameInput.gameObject.SetActive(false);
        okButton.gameObject.SetActive(false);
        title.gameObject.SetActive(false);
    }
}
