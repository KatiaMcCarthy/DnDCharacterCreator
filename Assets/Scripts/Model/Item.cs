using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item  {

    //Items have.....

    public string type ="";
    public string itemName = "";
    public int cost = 0;
    public string damageS = "";
    public string damageM = "";
    public string critical = "";
    public float range = 0;
    public float weight = 0;
    public string damageType = "";
    public string specialAbility = "";
    public string other = "";
    public int armorBonus = 0;
    public int maxDexBonus = 0;
    public int armorCheckPenality = 0;
    public int arcaneSpellFailure = 0;
    public int speed20 = 0;
    public int speed30 = 0;
    public string description;

    // end items have

    //Utility 
    public Item(string typ, string name, int cst, float wgt, string spcAbil, string oth, string desc)
    {
        type = typ;
        itemName = name;
        cost = cst;
        weight = wgt;
        specialAbility = spcAbil;
        other = oth;
        description = desc;
    }
    //Weapon
    public Item (string typ, string name, int cst, string dS, string dM, string crt, float rng, float wgt, string dmgTy, string spcAbil, string oth, string desc)
    {
        type = typ;
        itemName = name;
        cost = cst;
        damageS = dS;
        damageM = dM;
        critical = crt;
        range = rng;
        weight = wgt;
        damageType = dmgTy;
        specialAbility = spcAbil;
        other = oth;
        description = desc;
    }
    
    //Armor
    public Item(string typ, string name, int cst, float wgt, string spcAbil, string oth, int aB, int mDB, int aCP, int aSF, int sp2, int sp3, string desc)
    {
        type = typ;
        itemName = name;
        cost = cst;
        weight = wgt;
        specialAbility = spcAbil;
        other = oth;
        armorBonus = aB;
        maxDexBonus = mDB;
        armorCheckPenality = aCP;
        arcaneSpellFailure = aSF;
        speed20 = sp2;
        speed30 = sp3;
        description = desc;
    }

    //Wildcard
    public Item (string typ, string name, int cst, string dS, string dM, string crt, float rng, float wgt, string dmgTy, string spcAbil, string oth, int aB, int mDB, int aCP, int aSF, int sp2, int sp3, string desc)
    {
        type = typ;
        itemName = name;
        cost = cst;
        damageS = dS;
        damageM = dM;
        critical = crt;
        range = rng;
        weight = wgt;
        damageType = dmgTy;
        specialAbility = spcAbil;
        other = oth;
        armorBonus = aB;
        maxDexBonus = mDB;
        armorCheckPenality = aCP;
        arcaneSpellFailure = aSF;
        speed20 = sp2;
        speed30 = sp3;
        description = desc;
    }
   
}
