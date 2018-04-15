using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Skill : MonoBehaviour {

    //for player use
    public string skillName = "";
    public int total = 0;
    public int ranks = 0;
    public int abilityModfier = 0;
    public int trained;  //*lookat
    public int miscModfier = 0;
    public string abilityType = "";

    //for the data entry
    public string descriptoin = "";
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


    //player use
	public Skill (string name, int tot, int rnk, int abilMod, int train, int misMod, string abilType)
    {
        skillName = name;
        total = tot;
        ranks = rnk;
        abilityModfier = abilMod;
        trained = train;
        miscModfier = misMod;
        abilityType = abilType;
    }


}
