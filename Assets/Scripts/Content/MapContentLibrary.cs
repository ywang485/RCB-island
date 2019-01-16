using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapTileSlice {

    public string spritePath;
    public int sliceIdx;

    public MapTileSlice(string path, int idx)
    {
        spritePath = path;
        sliceIdx = idx;
    }

}

public class MapContentLibrary {

    static public readonly Dictionary<Map.mapGridType, MapTileSlice> mapTiles = new Dictionary<Map.mapGridType, MapTileSlice>() {
        {Map.mapGridType.undiscovered, new MapTileSlice("Sprites/MapTiles/rpgmakervx/Dungeon_A5", 1)},
        {Map.mapGridType.empty, new MapTileSlice("Sprites/MapTiles/rpgmakervx/Outside_A2", 1)},
        {Map.mapGridType.forest, new MapTileSlice("Sprites/MapTiles/rpgmakervx/World_A2", 11)}
    }; 
}

