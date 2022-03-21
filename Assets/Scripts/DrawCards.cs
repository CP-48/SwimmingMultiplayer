using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrawCards : MonoBehaviour
{

    public GameObject new_player1;
    public GameObject new_player2;
    public GameObject playerArea;
    public GameObject opponentArea;

    //public PlayerDeck deckObject;

    void Start()
    {
        
    }

    public void OnClick()
    {
        GameObject playerCard = Instantiate(new_player1, new Vector3(0, 0, 0), Quaternion.identity);

        playerCard.transform.SetParent(playerArea.transform);
    }

   
}
