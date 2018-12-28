using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player {

    bool aiControlled;
    NarrativeGoal narrativeGoal;

    public Player(bool isAIControlled)
    {
        aiControlled = isAIControlled;
        narrativeGoal = null;
    }

    public void setNarrativeGoal(NarrativeGoal goal)
    {
        narrativeGoal = goal;
    }

    public NarrativeGoal GetNarrativeGoal()
    {
        return narrativeGoal;
    }

}