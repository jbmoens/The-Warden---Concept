using UnityEngine;
using System.Collections;
using System;

public class GameBoard
{
    public int chunkCountX = 10;
    public int chunkCountZ = 10;

    int mapSizeX;
    int mapSizeZ;

    public int[] elevationMap;
    public Color[] colorMap;

    public GameBoard()
    {
        mapSizeX = chunkCountX * HexMetrics.chunkSizeX;
        mapSizeZ = chunkCountZ * HexMetrics.chunkSizeZ;
        elevationMap = new int[mapSizeX * mapSizeZ];
        colorMap = new Color[mapSizeX * mapSizeZ];

        for (int z = 0, i = 0; z < mapSizeZ; z++)
            for (int x = 0; x < mapSizeX; x++)
            {
                int e = elevationMap[i] = computeElevation(x, z);
                colorMap[i++] = Color.LerpUnclamped(Color.grey, Color.blue, (float)(e * 1.0f / (mapSizeX + mapSizeZ)));
            }
    }

    int computeElevation(int i, int j)
    {
        return (-i + j);
    }
}
