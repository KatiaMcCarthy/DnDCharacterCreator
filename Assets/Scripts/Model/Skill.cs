using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Skill {

    //for player use
    public string skillName = "";
    public int total = 0;
    public int ranks = 0;
    public int abilityModfier = 0;
    public int trained;  //*lookat
    public int miscModfier = 0;
    public string abilityType = "";

    //for the data entry
    public string description = "";
    public string checkDescription = "";
    public Image tableOne = null;
    public Image tableTwo = null;
    public Image tableThree = null;
    public Image tableFour = null;
    public Image tableFive = null;
    public string actionDescription = "";
    public string tryAgainDescription = "";
    public string special = "";
    public string other = "";
    public string feature = "";


    //player use
	public Skill (string name, int tot, int rnk, int abilMod, int train, int misMod, string feat, string abilType)
    {
        skillName = name;
        total = tot;
        ranks = rnk;
        abilityModfier = abilMod;
        trained = train;
        miscModfier = misMod;
        abilityType = abilType;
        feature = feat;
    }

    //dicitionary use
    public Skill(string name, int tot, int rnk, int abilMod, int train, int misMod, string abilType, string chkDesc, string actDesc, string tryAgainDesc, string otr, string spec, string feat, Image tblOne, Image tblTwo, Image tblThree, Image tblFour, Image tblFive)
    {
        skillName = name;
        abilityType = abilType;
        total = tot;
        ranks = rnk;
        abilityModfier = abilMod;
        trained = train;
        miscModfier = misMod;
        checkDescription = chkDesc;
        actionDescription = actDesc;
        tryAgainDescription = tryAgainDesc;
        other = otr;
        special = spec;
        feature = feat;
        tableOne = tblOne;
        tableTwo = tblTwo;
        tableThree = tblThree;
        tableFour = tblFour;
        tableFive = tblFive;

    }


}
