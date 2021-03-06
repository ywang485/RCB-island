﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterContentLibrary {

    // Skin color parameters
    static public readonly float bodySkinRBase = 1f;
    static public readonly float bodySkinGBase = 0.914f;
    static public readonly float bodySkinBBase = 0.85f;
    static public readonly float bodySkinBrightnessMax = 1.0f;
    static public readonly float bodySkinBrightnessMin = 0.6f;

    // Hair color parameters
    static public readonly float hairBrightnessMin = 0.1f;
    static public readonly float hairBrightnessMax = 0.6f;

    // Outfit color parameters
    static public readonly float outfitBrightnessMin = 0.0f;
    static public readonly float outfitBrightnessMax = 1.0f;

    // Body component library
    static public readonly string[] maleHairs = new string[] { "Sprites/Character/Hair-4", "Sprites/Character/Hair-8", "Sprites/Character/Hair-5" };
    static public readonly string[] femaleHairs = new string[] { "Sprites/Character/Hair-9", "Sprites/Character/Hair-2", "Sprites/Character/Hair-3", "Sprites/Character/Hair-6", "Sprites/Character/Hair-7" };
    static public readonly string[] femaleOutfit = new string[] { "Sprites/Character/Outfit-1"};
    static public readonly string[] maleOutfit = new string[] { "Sprites/Character/Outfit-1" };

    // Name templates
    static public readonly string[] femaleFirstNames = new string[] {"emma", "ava", "mia", "charlotte", "harper", "ella", "scarlett",
                                                                     "mila", "lily", "chloe", "layla", "ellie", "riley", "luna", "zoey",
                                                                     "hannah", "nora", "aubrey", "bella", "stella", "maya", "skylar",
                                                                     "paisley", "audrey", "brooklyn", "lucy", "zoe", "hazel", "eva",
                                                                     "aaliyah", "anna", "leah", "kinsley", "alice", "sophie", "sarah",
                                                                     "hailey", "autumn", "peyton", "sadie"};
    static public readonly string[] maleFirstNames = new string[] {"liam", "noah", "logan", "lucas", "mason", "oliver", "ethan",
                                                                   "elijah", "aiden", "james", "benjamin", "jackson", "sebastian",
                                                                   "jacob", "alexander", "carter", "michael", "daniel", "jack",
                                                                   "william", "jayden", "wyatt", "luke", "grayson", "matthew",
                                                                   "henry", "gabriel", "owen", "levi", "julian", "ryan", "leo",
                                                                   "jaxon", "lincoln", "nathan", "muhammad", "adam", "samuel",
                                                                   "david", "isaiah", "dampster"};
    static public readonly string[] lastNames = new string[] {"smith", "johnson", "williams", "jones", "brown", "davis", "miller",
                                                              "wilson", "moore", "taylor", "anderson", "thomas", "jackson", "white",
                                                              "harris", "thompson", "garcia", "martinez", "long", "russell", "hughes",
                                                              "butler", "bailey", "torres", "gray", "watson", "brooks", "bryant",
                                                              "powell", "griffin", "diaz", "hayes", "kelly", "peterson", "rivera",
                                                              "howard", "cooper", "cox", "stewart", "morris", "bennett", "wood",
                                                              "reed", "cook", "murphy", "ross", "lee", "powell", "wong", "wilson"};

    


}
