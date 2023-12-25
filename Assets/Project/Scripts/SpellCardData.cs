using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "NewSpellCard", menuName = "Cards/SpellCard")]
public class SpellCardData : ScriptableObject
{
    public string cardName;
    public Sprite image;
    public string info;
    public int manaCost;
    public SpellCard.SpellType spellType;
    public int spellValue;
    public SpellCard.SpellTargetType spellTargetType;
}
