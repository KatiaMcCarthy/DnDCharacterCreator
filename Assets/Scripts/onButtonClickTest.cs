using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class onButtonClickTest : MonoBehaviour {

   public void OnButtonClick()
    {
        Character myChar = new Character();

        Feat temp = null;

        if(AppLibary.featDictionary.TryGetValue("Power Attack", out temp))
        {
            Debug.Log(temp.featName);
            Debug.Log(temp.features);
        }
    }

}
