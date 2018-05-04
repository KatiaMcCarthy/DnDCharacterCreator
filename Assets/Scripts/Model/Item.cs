using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item  {

    //Items have.....

    public string type ="";
    public string itemName = "";
    public float cost = 0;
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
    public string description = "";
    public string material = "";
    public bool scalable = false;

    // end items have

    //Utility 
    public Item(string typ, string name, float cst, float wgt, string spcAbil, string oth, bool scle, string desc)
    {
        type = typ;
        itemName = name;
        cost = cst;
        weight = wgt;
        specialAbility = spcAbil;
        other = oth;
        scalable = scle;
        description = desc;
    }
    //Weapon
    public Item (string typ, string name, float cst, string dS, string dM, string crt, float rng, float wgt, string dmgTy, string spcAbil, string oth, string desc)
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
    public Item(string typ, string name, float cst, float wgt, string spcAbil, string oth, int aB, int mDB, int aCP, int aSF, int sp3, int sp2, string mat, string desc)
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
        speed30 = sp3;
        speed20 = sp2;
        material = mat;
        description = desc;
    }

    //Wildcard
    public Item (string typ, string name, int cst, string dS, string dM, string crt, float rng, float wgt, string dmgTy, string spcAbil, string oth, int aB, int mDB, int aCP, int aSF, int sp2, int sp3,string mat, bool scle, string desc)
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
        material = mat;
        scalable = scle;
        description = desc;

    }
   
}
