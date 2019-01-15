﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapView : MonoBehaviour {

    private GameManager gameManager;
    public Map map;
    static private int tileStartingX = 0;
    static private int tileStartingY = 0;
    static private float tileWidth = 0.4f;
    static private float tileHeight = 0.4f;

	// Use this for initialization
	void Start () {
        gameManager = GameManager.getGameManager();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void UpdateMapview()
    {
        for (int i = 0; i < map.getMapHeight(); i ++)
        {
            for (int j = 0; j < map.getMapWidth(); j ++)
            {
                GameObject.Instantiate(Resources.Load<GameObject>(SystemComponents.mapTile), new Vector2(tileStartingX + i * tileWidth, tileStartingY + j * tileHeight), Quaternion.identity, transform);
            }
        }
    }
}