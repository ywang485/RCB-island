using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class GameManager : MonoBehaviour {

    private Player[] players;
    private int numPlayers = 2;
    private int currPlayer = 0;

    // Temporary
    public Text infoText;

    void InitializeGame()
    {
        CreatePlayers();
        currPlayer = 0;
    }

    void CreatePlayers()
    {
        // Draw numPlayers narative goals
        int[] goalIds = Util.DrawWithoutRepeat(0, ContentLibrary.narrativeGoals.Length, numPlayers);

        players = new Player[numPlayers];
        for(int i = 0; i < numPlayers; i ++)
        {
            players[i] = new Player(false);
            players[i].setNarrativeGoal(ContentLibrary.narrativeGoals[goalIds[i]]);

        }
    }

	// Use this for initialization
	void Start () {
        InitializeGame();
    }
	
	// Update is called once per frame
	void Update () {

        string playerGoalText = "";
        for (int i = 0; i < numPlayers; i++)
        {
            playerGoalText += "Player " + i + " assigned narrative goal: " + players[i].GetNarrativeGoal().getName() + "\n";
        }
        infoText.text = numPlayers + " players created\n" + playerGoalText + "\n" + 
            "Player " + (currPlayer + 1) + "'s turn: ";
    }

    public void EnterPlayerAction(int actionIdx)
    {
        Debug.Log("Player " + currPlayer + " chose Action " + actionIdx);
        currPlayer = (currPlayer + 1) % numPlayers;
    }
}
