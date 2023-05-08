using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

[CreateAssetMenu(fileName = "New wepon", menuName = "Wepon")]
public class Wepon : ScriptableObject
{
    
    public Sprite weponSprite;
    [Header("Stats")]
    public float weponDamage=6;
    public float lineForce=13;
    public float lineBreak=0.2f;

    [Header("Gems")]
    [Min(1)]
    public float redGem; // weponDamage * redGem
    [Min(1)]
    public float greenGem; // lineForce * greenGem
    [Min(1)]
    public float yellowGem; // lineBreak * yellowGem
    [Min(1)]
    public float purpleGem; // weponDamage * purpleGem | lineForce * purpleGem | lineBreak * purpleGem 

}
