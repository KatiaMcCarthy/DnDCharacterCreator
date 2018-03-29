using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character{

   public List<Item> items = new List<Item>();
   public List<Stat> stats = new List<Stat>();
   public List<Feat> feats = new List<Feat>();
   public List<Skill> skills = new List<Skill>();

    // Use this for initialization
    void Start () {


    }
    
    //adds weapon
   public void AddItemWeapon(string type, string itemName, int cost, string damageS, string damageM, string critical, float range, float weight, string damageType, string specialAbility, string other){

      }
    //adds armor
   public void AddItemDefensive(string type, string itemName, int cost, int armorBonus, int maxDexBonus, int armorCheckPenailty, int arcaneFaliureChange, int speed20, int speed30, float weight, string other)
    {

    }
    //ads utility
   public void AddItemUtility(string type, string itemName, int cost, float weight, string other, string description)
    {

    }

}
