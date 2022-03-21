using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CardDisplay : MonoBehaviour
{
    public Card2 card;
    
    public Text nameText;
    public Text descriptionText;

    void Start()
    {
        nameText.text = card.name;
        descriptionText.text = card.description;
    }
}
