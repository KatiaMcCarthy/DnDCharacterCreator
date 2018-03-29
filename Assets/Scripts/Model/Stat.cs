using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stat : MonoBehaviour {

    public int value = 0;
    public int abilityMod = 0;
    public int tempMod = 0;
    public int miscMod = 0;
    public int enhanceMod = 0;
    public int deflectMod = 0;
    public int naturalMod = 0;
    public int sizeMod = 0;
    public int dodgeMod = 0;
   
    public Stat (int val, int abilMod, int tmpMod, int mscMod, int enhanMod, int deflMod, int natMod, int size, int dodge)
    {
        value = val;
        abilityMod = abilMod;
        tempMod = tmpMod;
        miscMod = mscMod;
        enhanceMod = enhanMod;
        deflectMod = deflMod;
        naturalMod = natMod;
        sizeMod = size;
        dodgeMod = dodge;
    }

}
