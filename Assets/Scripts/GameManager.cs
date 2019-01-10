using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class GameManager : MonoBehaviour {

    private Player[] players;
    private Character[] characters;
    private int numPlayers = 2;
    private int numCharacters = 5;
    private int currPlayer = 0;

    // Temporary
    public Text infoText;
    public GameObject[] characterIcons;
    // End: Temporarys

    void InitializeGame()
    {
        CreatePlayers();
        CreateCharacters();
        currPlayer = 0;
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

        // Temporary
        for (int i = 0; i < numCharacters; i++)
        {
            characterIcons[i].transform.Find("CharacterIcon").GetComponent<Image>().color = new Color(CharacterContentLibrary.bodySkinRBase * characters[i].getSkinBrightness(), CharacterContentLibrary.bodySkinGBase * characters[i].getSkinBrightness(), CharacterContentLibrary.bodySkinBBase * characters[i].getSkinBrightness());
            characterIcons[i].transform.Find("CharacterIcon").transform.Find("Hair").GetComponent<Image>().color = characters[i].getHairColor();
            characterIcons[i].transform.Find("CharacterIcon").transform.Find("Outfit").GetComponent<Image>().color = characters[i].getOutfitColor();
            if (characters[i].getGender() > 0) {
                characterIcons[i].transform.Find("CharacterIcon").transform.Find("Hair").GetComponent<Image>().sprite = Resources.Load<Sprite>(CharacterContentLibrary.maleHairs[characters[i].getHairIdx()]);
                characterIcons[i].transform.Find("CharacterIcon").transform.Find("Outfit").GetComponent<Animator>().runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>(CharacterContentLibrary.maleOutfit[characters[i].getOutfitIdx()]);
            } else
            {
                characterIcons[i].transform.Find("CharacterIcon").Find("Hair").GetComponent<Image>().sprite = Resources.Load<Sprite>(CharacterContentLibrary.femaleHairs[characters[i].getHairIdx()]);
                characterIcons[i].transform.Find("CharacterIcon").Find("Outfit").GetComponent<Animator>().runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>(CharacterContentLibrary.femaleOutfit[characters[i].getOutfitIdx()]);
            }
            characterIcons[i].transform.Find("CharacterIcon").transform.Find("NameTag").GetComponent<Text>().text = Util.UppercaseFirst(characters[i].getFirstName()) + "\n" + Util.UppercaseFirst(characters[i].getLastName());
        }
        // End: Temporary
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
