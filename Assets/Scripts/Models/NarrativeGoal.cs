using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NarrativeGoal {

    string name;
    string formula;

    public NarrativeGoal(string newName, string newFormula)
    {
        name = newName;
        formula = newFormula;
    }

    public string getName()
    {
        return name;
    }

    public string getFormula()
    {
        return formula;
    }

}
