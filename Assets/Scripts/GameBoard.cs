using UnityEngine;
using System.Collections;
using System;

public class GameBoard
{
    public int chunkCountX = 2;
    public int chunkCountZ = 2;

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
//        return (-i + j);
		Vector3 position = new Vector3();
		position.x = (float)i;
		position.z = (float)j;
		int ret = (int)((HexMetrics.SampleNoise (position).y-0.6f) * 50.0f);

		if (i<2 || i>mapSizeX-2 || j<2 || j>mapSizeZ-2) ret =-2;

		return ret;
    }
}
