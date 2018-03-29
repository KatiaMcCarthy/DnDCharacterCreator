using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Skill : MonoBehaviour {

    public string skillName = "";
    public int total = 0;
    public int ranks = 0;
    public int abilityModfier = 0;
    public int trained;  //*lookat
    public int miscModfier = 0;
    public string abilityType = "";

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
