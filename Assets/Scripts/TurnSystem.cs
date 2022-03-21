using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TurnSystem : MonoBehaviour
{
    public bool isYourTurn;
    public int yourTurn;
    public int isOpponentTurn;
    public Text turnText;

    public int maxMana;
    public int currentMana;
    public Text manaText;

    public static bool startTurn;

    // Start is called before the first frame update
    void Start()
    {
        isYourTurn = true;
        yourTurn = 1;
        isOpponentTurn = 0;

        maxMana = 1;
        currentMana = 1;

        startTurn = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(isYourTurn == true)
        {
            turnText.text = "Your Turn";
        }

        else
        {
            turnText.text = "Opponent Turn";
        }

        manaText.text = currentMana + " / " + maxMana;
    }

    public void EndYourTurn()
    {
        isYourTurn = false;
        isOpponentTurn += 1;
    }

    public void EndOpponentTurn()
    {
        isYourTurn = true;
        yourTurn += 1;

        maxMana += 1;
        currentMana = maxMana;

        startTurn = true;
    }
}
