using UnityEngine;
using UnityEngine.UI;
[System.Serializable]

public class Card
{
    public int id;
    public string cardName;
    public Sprite spriteImage;

    public Card()
    {

    }

    public Card(int Id, string CardName, Sprite SpriteImage)
    {
        id = Id;
        cardName = CardName;
        spriteImage = SpriteImage; 
    }
}
