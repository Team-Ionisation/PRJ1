using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TerrainGen : MonoBehaviour {
	public int width = 1024;
	public int height = 1024;
	public int depth = 30;
	public float scale = 40f;
	void Start() {
		
		Terrain terrain = GetComponent<Terrain> ();
		terrain.terrainData = generateTerrain (terrain.terrainData);

	}
	TerrainData generateTerrain(TerrainData terraindata) {
		terraindata.heightmapResolution = width + 1;
		terraindata.size = new Vector3 (width, depth, height);
		terraindata.SetHeights (0, 0, generateHeights ());
		return terraindata;

	
	}
	float[,] generateHeights()
	{
		float[,] heights = new float[width, height];
		for (int x = 0; x < width; x++) {
			for (int y = 0; y < width; y++) {
				heights [x, y] = CalculateHeight (x, y);
			}
		
		}
		return heights;

	}
	float CalculateHeight(int x, int y) {

		float xCoord = (float)x / height * scale;
		float yCoord = (float)y / height * scale;
		return Mathf.PerlinNoise (xCoord, yCoord);


	}
}
