using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class onButtonClickTest : MonoBehaviour
{

    public void OnButtonClick()
    {
        Character myChar = new Character();

        Feat temp = null;
        CharacterClass tempClass = null;

        if (AppLibary.featDictionary.TryGetValue(AppLibary.AlignmentChannel, out temp))
        {
            Debug.Log(temp.featName);
            Debug.Log(temp.features);
            Debug.Log(temp.description);
            Debug.Log(temp.special);
        }

        if (AppLibary.characterClassDictionary.TryGetValue(AppLibary.Fighter, out tempClass))
        {
            Debug.Log(tempClass.className);
            Debug.Log(tempClass.description);
            Debug.Log(tempClass.role);
            Debug.Log(tempClass.alignment);
            Debug.Log(tempClass.hitDie);
            Debug.Log(tempClass.classSkills);
            Debug.Log(tempClass.skillRanksLevel);

            ClassAbility tempClassAbility = null;
            if (tempClass.characterClassAbilities.TryGetValue(AppLibary.Bravery, out tempClassAbility))
            {
                Debug.Log(tempClassAbility.abilityName);
                Debug.Log(tempClassAbility.description);
                Debug.Log(tempClassAbility.feature);
            }


        }

    }
}
