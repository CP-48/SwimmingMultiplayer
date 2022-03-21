using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Card", menuName = "Card")]
public class Card2 : ScriptableObject
{
   public new string name;
   public string description;

   public void Print()
   {
       Debug.Log(name + ": " + description);
   }
}
