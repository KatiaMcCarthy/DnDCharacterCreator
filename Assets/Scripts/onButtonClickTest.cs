using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class onButtonClickTest : MonoBehaviour {

   public void OnButtonClick()
    {
        Character myChar = new Character();

        Feat temp = null;

        if(AppLibary.featDictionary.TryGetValue(AppLibary.AlignmentChannel, out temp))
        {
            Debug.Log(temp.featName);
            Debug.Log(temp.features);
            Debug.Log(temp.description);
            Debug.Log(temp.special);
        }

    }

}
