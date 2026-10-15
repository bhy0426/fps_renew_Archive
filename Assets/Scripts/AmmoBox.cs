using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AmmoBox : MonoBehaviour
{
    public enum Ammo { normal, piercing, explosive };
    public Ammo boxAmmoName; // ÅºÁ¾ ÀÌ¸§
    public int ammo; // Ãß°¡µÉ Åº¾à ¼ö

    void Awake()
    {
        /*boxAmmoName = Ammo.normal;*/
    }
}
