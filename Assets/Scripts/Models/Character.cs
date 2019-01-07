﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character {

    string firstName;
    string lastName;
    int gender;

    // Appearance related
    float skinBrightness;
    int hairIdx;
    Color hairColor;
    int outfitIdx;
    Color outfitColor;

    string[] traits;

    bool isAlive;
    bool isInjured;
    int hunger;
    int thirst;
    int sanity;

    int virtue_pts;
    int vice_pts;

    public Character()
    {
        // Generate gender
        gender = Random.Range(0, 2);

        // Gender Related Parameters
        if (gender > 0)
        {
            firstName = CharacterContentLibrary.maleFirstNames[Random.Range(0, CharacterContentLibrary.maleFirstNames.Length)];
            hairIdx = Random.Range(0, CharacterContentLibrary.maleHairs.Length);
            outfitIdx = Random.Range(0, CharacterContentLibrary.maleOutfit.Length);
        } else
        {
            firstName = CharacterContentLibrary.femaleFirstNames[Random.Range(0, CharacterContentLibrary.femaleFirstNames.Length)];
            hairIdx = Random.Range(0, CharacterContentLibrary.femaleHairs.Length);
            outfitIdx = Random.Range(0, CharacterContentLibrary.femaleOutfit.Length);
        }
        lastName = CharacterContentLibrary.lastNames[Random.Range(0, CharacterContentLibrary.lastNames.Length)];

        // Generate appearance
        skinBrightness = Random.Range(CharacterContentLibrary.bodySkinBrightnessMin, CharacterContentLibrary.bodySkinBrightnessMax);
        float hairColorR = Random.Range(CharacterContentLibrary.hairBrightnessMin, CharacterContentLibrary.hairBrightnessMax);
        float hairColorG = Random.Range(CharacterContentLibrary.hairBrightnessMin, CharacterContentLibrary.hairBrightnessMax);
        float hairColorB = Random.Range(CharacterContentLibrary.hairBrightnessMin, CharacterContentLibrary.hairBrightnessMax);
        hairColor = new Color(hairColorR, hairColorG, hairColorB);
        float outfitColorR = Random.Range(CharacterContentLibrary.outfitBrightnessMin, CharacterContentLibrary.outfitBrightnessMax);
        float outfitColorG = Random.Range(CharacterContentLibrary.outfitBrightnessMin, CharacterContentLibrary.outfitBrightnessMax);
        float outfitColorB = Random.Range(CharacterContentLibrary.outfitBrightnessMin, CharacterContentLibrary.outfitBrightnessMax);
        outfitColor = new Color(outfitColorR, outfitColorG, outfitColorB);

    }

    public string getFirstName()
    {
        return firstName;
    }

    public string getLastName()
    {
        return lastName;
    }
  
    public float getSkinBrightness()
    {
        return skinBrightness;
    }

    public Color getHairColor()
    {
        return hairColor;
    }

    public int getGender()
    {
        return gender;
    }

    public int getHairIdx()
    {
        return hairIdx;
    }

    public int getOutfitIdx()
    {
        return outfitIdx;
    }

    public Color getOutfitColor()
    {
        return outfitColor;
    }
}
