using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerNameInputs : MonoBehaviour
{
    public InputField field;
    public int playerNumber = 1;
    // Start is called before the first frame update
    void Start()
    {
        //InputField input = field.GetComponent<InputField>();
        //input.onValueChanged.AddListener(nameSet);
    }

    // Update is called once per frame
    void nameSet()
    {
        Debug.Log("It works!");
    }
}
