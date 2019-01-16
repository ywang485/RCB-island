using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapTile : MonoBehaviour {

    public void setTileTypeShown(Map.mapGridType t)
    {
        MapTileSlice slice = MapContentLibrary.mapTiles[t];
        Object[] sheet = Resources.LoadAll(slice.spritePath);
        GetComponent<SpriteRenderer>().sprite = (Sprite) sheet[slice.sliceIdx];
    }

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
