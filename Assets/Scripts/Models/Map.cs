using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Map {
    public enum mapGridType {
        undiscovered = 0,
        empty = 1,
        bushes = 2,
        forest = 3,
        river = 4,
        island_edge = 5
    };

    private mapGridType[,] mapGrid;
    private int mapWidth = 100;
    private int mapHeight = 100;

    public Map()
    {
        mapGrid = new mapGridType[mapHeight, mapWidth];
        mapGrid[0, 0] = mapGridType.empty;
    }

    public mapGridType getMapGrid(int x, int y)
    {
        return mapGrid[x, y];
    }

    public int getMapWidth()
    {
        return mapWidth;
    }

    public int getMapHeight()
    {
        return mapHeight;
    }
}
