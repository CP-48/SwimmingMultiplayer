using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardDatabase : MonoBehaviour
{
    public static List<Card> cardList = new List<Card>();

    void Awake()
    {
        cardList.Add(new Card(1, "Ace of Clubs", Resources.Load<Sprite>("Card_Decks/Clubs/Ace_clubs")));
        cardList.Add(new Card(2, "Ace of Diamonds", Resources.Load<Sprite>("Ace of diamonds")));
        cardList.Add(new Card(3, "Ace of Hearts", Resources.Load<Sprite>("ace of hearts")));
        cardList.Add(new Card(4, "Ace of Spades", Resources.Load<Sprite>("ace of spades")));
        
        cardList.Add(new Card(5, "10 of Clubs", Resources.Load<Sprite>("Card_Decks/Clubs/10 of clubs")));
        cardList.Add(new Card(6, "Jack of Clubs", Resources.Load<Sprite>("Card_Decks/Clubs/jack of clubs")));
        cardList.Add(new Card(7, "King of Clubs", Resources.Load<Sprite>("Card_Decks/Clubs/king of clubs")));
        cardList.Add(new Card(8, "Queen of Clubs", Resources.Load<Sprite>("Card_Decks/Clubs/queen of clubs")));

        cardList.Add(new Card(9, "10 of Diamonds", Resources.Load<Sprite>("10 of diamonds")));
        cardList.Add(new Card(10, "Jack of Diamonds", Resources.Load<Sprite>("jack of diamonds")));
        cardList.Add(new Card(11, "King of Diamonds", Resources.Load<Sprite>("king of diamonds")));
        cardList.Add(new Card(12, "Queen of Diamonds", Resources.Load<Sprite>("queen of diamonds")));

        cardList.Add(new Card(13, "10 of Hearts", Resources.Load<Sprite>("10 of hearts")));
        cardList.Add(new Card(14, "Jack of Hearts", Resources.Load<Sprite>("jack of hearts")));
        cardList.Add(new Card(15, "King of Hearts", Resources.Load<Sprite>("king of hearts")));
        cardList.Add(new Card(16, "Queen of Hearts", Resources.Load<Sprite>("queen of hearts")));

        cardList.Add(new Card(17, "10 of Spades", Resources.Load<Sprite>("10 of spades")));
        cardList.Add(new Card(18, "Jack of Spades", Resources.Load<Sprite>("jack of spades")));
        cardList.Add(new Card(19, "King of Spades", Resources.Load<Sprite>("king of spades")));
        cardList.Add(new Card(20, "Queen of Spades", Resources.Load<Sprite>("queen of spades")));
    }
}
