using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Feat  {

    public string featName = "";
    public string features = "";
    public string description = "";
    public string special = "";
    public string normal = "";
    public Image table = null;
    
	// Use this for initialization
	public Feat(string name, string feature, string descript, string spec)
    {
        featName = name;
        features = feature;
        description = descript;
        special = spec;
    }

    public Feat(string name, string feature, string descript, string spec , string norm)
    {
        featName = name;
        features = feature;
        description = descript;
        special = spec;
        normal = norm;
    }

    public Feat(string name, string feature, string descript, string spec, string norm, Image tbl)
    {
        featName = name;
        features = feature;
        description = descript;
        special = spec;
        table = tbl;
        normal = norm;
    }


}
