using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClassAbility {

    public string abilityName = "";
    public string description = "";
    public string feature = "";
    public Image tableOne = null;
    public Image tableTwo = null;
    public Image tableThree = null;

    public ClassAbility (string ablName, string des, string feat, Image tb1, Image tb2, Image tb3)
    {
        abilityName = ablName;
        description = des;
        feature = feat;
        tableOne = tb1;
        tableTwo = tb2;
        tableThree = tb3;
    }
}
