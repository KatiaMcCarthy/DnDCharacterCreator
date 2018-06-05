using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class CharacterClass
{ 
    public string className = "";
    public string description = "";
    public string role = "";
    public string alignment = "";
    public string hitDie = "";
    public string classSkills = "";
    public string skillRanksLevel = "";
    public Image mainTable = null;

    public Dictionary<string, ClassAbility> characterClassAbilities = new Dictionary<string, ClassAbility>();
    
    public CharacterClass(string clName, string des, string rol, string align, string hD, string clSkil, string skillRank, Image mainTbl, Dictionary<string, ClassAbility> dict)
    {
        className = clName;
        description = des;
        role = rol;
        alignment = align;
        hitDie = hD;
        classSkills = clSkil;
        skillRanksLevel = skillRank;
        mainTable = mainTbl;
        characterClassAbilities = dict;
    }

}

