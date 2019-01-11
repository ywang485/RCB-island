using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CharacterStatusUI : MonoBehaviour {

    // Model
    public Character character;

    // UI
    private GameObject characterIcon;
    private ValueBar hungerBar;
    private ValueBar thirstBar;
    private ValueBar sanityBar;
    

	// Use this for initialization
	void Start () { 
        characterIcon = transform.Find("CharacterIcon").gameObject;
        hungerBar = transform.Find("HungerBar").gameObject.GetComponent<ValueBar>();
        thirstBar = transform.Find("ThirstBar").gameObject.GetComponent<ValueBar>();
        sanityBar = transform.Find("SanityBar").gameObject.GetComponent<ValueBar>();

        characterIcon.GetComponent<Image>().color = new Color(CharacterContentLibrary.bodySkinRBase * character.getSkinBrightness(), CharacterContentLibrary.bodySkinGBase * character.getSkinBrightness(), CharacterContentLibrary.bodySkinBBase * character.getSkinBrightness());
        characterIcon.transform.Find("Hair").GetComponent<Image>().color = character.getHairColor();
        characterIcon.transform.Find("Outfit").GetComponent<Image>().color = character.getOutfitColor();
        if (character.getGender() > 0)
        {
            characterIcon.transform.Find("Hair").GetComponent<Image>().sprite = Resources.Load<Sprite>(CharacterContentLibrary.maleHairs[character.getHairIdx()]);
            characterIcon.transform.Find("Outfit").GetComponent<Animator>().runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>(CharacterContentLibrary.maleOutfit[character.getOutfitIdx()]);
        }
        else
        {
            characterIcon.transform.Find("Hair").GetComponent<Image>().sprite = Resources.Load<Sprite>(CharacterContentLibrary.femaleHairs[character.getHairIdx()]);
            characterIcon.transform.Find("Outfit").GetComponent<Animator>().runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>(CharacterContentLibrary.femaleOutfit[character.getOutfitIdx()]);
        }
        characterIcon.transform.Find("NameTag").GetComponent<Text>().text = Util.UppercaseFirst(character.getFirstName()) + "\n" + Util.UppercaseFirst(character.getLastName());

    }

    // Update is called once per frame
    void Update () {
        hungerBar.percentage = (float)character.getHunger() / (float)Character.maxHunger;
        thirstBar.percentage = (float)character.getThirst()) / (float)Character.maxThirst;
        sanityBar.percentage = (float)character.getSanity() / (float)Character.maxSanity;
	}
}
