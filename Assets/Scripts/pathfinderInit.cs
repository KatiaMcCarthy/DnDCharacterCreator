using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// *HasPrereq = look at later, skill has prereq 


public class pathfinderInit : MonoBehaviour {

    string tempName = "";
    string tempFeature = "";
    string tempDescription = "";


	// Use this for initialization
	void Start () {


        InitalizeFeats();

    }

    void InitalizeFeats()
    {
        //creates a feat called Acrobatic and adds it to the libary

        tempName = AppLibary.Acrobatic;
        tempFeature = "You get a +2 bonus on all Arcobatics and Fly checks. if you have 10 or more ranks in one of these skills it increases to +4 for that skill.";
        tempDescription = "You are skilled at leaping, jumping, and flying.";

        Feat acrobatic = new Feat(tempName, tempFeature, tempDescription);
        if (!AppLibary.featDictionary.ContainsKey(AppLibary.Acrobatic))
        {
            AppLibary.featDictionary.Add(AppLibary.Acrobatic, acrobatic);
        }

        // end add Acrobatic

        //Acrobatic Steps
        //*HasPrereq
        tempName = "Acrobatic Steps";
        tempFeature = "Whenever you move you may mmove through up to 15 feet of difficult terrain each round as if it was normal terrain. This effect stacks with those provided by Nimble Moves.";
        tempDescription = "You can easily move over and through obsticles.";

        Feat acrobaticSteps = new Feat(tempName, tempFeature, tempDescription);
        if(!AppLibary.featDictionary.ContainsKey("Acrobatic Steps"))
        {
            AppLibary.featDictionary.Add("Acrobatic Steps", acrobaticSteps);
        }

        // end Acrobatic Steps

        //Alertness

        tempName = "Alertness";
        tempFeature = "You get a +2 bonus on Perception and Sense Motive skill checks. If you have 10 or more ranks in one of these skills, the bonus increases to +4 for that skill.";
        tempDescription = "You often notice things that others may miss.";

        Feat alertness = new Feat(tempName, tempFeature, tempDescription);
        if(!AppLibary.featDictionary.ContainsKey("Alertness"))
        {
            AppLibary.featDictionary.Add("Alerntess", alertness);
        }

        //end Alertness
    }


}
