using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Atribute {

    //read in from user
    public int value = 0;
    public int modifierTotal = 0;
    public string atributeName = "";
    public string abilityType = "";

    //used for calculations
    public int racialMod = 0;
    public int itemMod = 0;
    public int situationalMod = 0;

    // Use this for initialization
    public Atribute(int val, int modTot, string name, string ability, int racMod, int itmMod, int sitMod)
        {
        value = val;
        modifierTotal = modTot;
        atributeName = name;
        abilityType = ability;
        racialMod = racMod;
        itemMod = itmMod;
        situationalMod = sitMod;
    }
}
