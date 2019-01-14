using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class GameManager : MonoBehaviour {

    private Player[] players;
    public Character[] characters;
    private int numPlayers = 2;
    private int numCharacters = 5;
    private int currPlayer = 0;

    static GameManager instance;

    public GameObject characterStatusStartingPosition;

    // Temporary
    public Text infoText;
    // End: Temporarys

    static GameManager getGameManager()
    {
        if (instance == null) {
            instance = GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManager>();
        }

        return instance;
    }

    void InitializeGame()
    {
        CreatePlayers();
        CreateCharacters();
        CreateCharacterStatusUI();
        currPlayer = 0;
    }

    void CreateCharacterStatusUI()
    {
        for (int i = 0; i < characters.Length; i ++)
        {
            CharacterStatusUI characterStatus = GameObject.Instantiate(Resources.Load<GameObject>(SystemComponents.characterStatusUI), new Vector2(25.0f + i * 125.0f, 35.0f), Quaternion.identity, GameObject.Find("CharacterPanel").transform).GetComponent<CharacterStatusUI>();
            characterStatus.character = characters[i];
        }
    }

    void CreatePlayers()
    {
        // Draw numPlayers narative goals
        int[] goalIds = Util.DrawWithoutRepeat(0, StoryContentLibrary.narrativeGoals.Length, numPlayers);

        players = new Player[numPlayers];
        for(int i = 0; i < numPlayers; i ++)
        {
            players[i] = new Player(false);
            players[i].setNarrativeGoal(StoryContentLibrary.narrativeGoals[goalIds[i]]);

        }
    }

    void CreateCharacters()
    {
        characters = new Character[numCharacters];
        for (int i = 0; i < numCharacters; i ++)
        {
            characters[i] = new Character();
        }
    }

	// Use this for initialization
	void Start () {
        InitializeGame();
    }
	
	// Update is called once per frame
	void Update () {

        string playerGoalText = "";
        string characterInfoText = "";
        for (int i = 0; i < numPlayers; i++)
        {
            playerGoalText += "Player " + i + " assigned narrative goal: " + players[i].GetNarrativeGoal().getName() + "\n";
        }
        infoText.text = numPlayers + " players created\n" + playerGoalText + "\n" +
            numCharacters + " characters created\n" + characterInfoText + "\n" + 
            "Player " + (currPlayer + 1) + "'s turn: ";
    }

    public void EnterPlayerAction(int actionIdx)
    {
        Debug.Log("Player " + currPlayer + " chose Action " + actionIdx);
        currPlayer = (currPlayer + 1) % numPlayers;
    }
}
