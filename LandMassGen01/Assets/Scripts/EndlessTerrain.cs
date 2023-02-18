using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndlessTerrain : MonoBehaviour
{
    // public const float maxViewDst = 300;
    // public Transform viewer;
    // public static Vector2 viewerPosition;
    // int chunkSize;
    // int chunksVisibleInViewDst;
    // Dictionary<Vector2, TerrainChunk> terrainChunkDictionary = new Dictionary<Vector2, TerrainChunk>();
    // void Start()
    //  {
    //     chunkSize = MapGenerator.mapChunkSize - 1;
    //     chunksVisibleInViewDst = Mathf.RoundToInt(maxViewDst / chunkSize);
    // }
    // void UpdateVisibleChunks()
    // {
    //     int currentChunkCoordX = Mathf.RoundToInt(viewerPosition.x / chunkSize);
    //     int currentChunkCoordY = Mathf.RoundToInt(viewerPosition.y / chunkSize);
    //     for(int yOffset = -chunksVisibleInViewDst; yOffset <= chunksVisibleInViewDst; yOffset++)
    //     {
    //         for(int xOffset = -chunksVisibleInViewDst; xOffset <= chunksVisibleInViewDst; xOffset++)
    //         {
    //             Vector2 viewedChunkCoord = new Vector2(currentChunkCoordX + xOffset, currentChunkCoordY + yOffset);
    //             if(terrainChunkDictionary.ContainsKey(viewedChunkCoord))
    //             {
    //                 terrainChunkDictionary[viewedChunkCoord].UpdateTerrainChunk();
    //             }
    //             else
    //             {
    //                 terrainChunkDictionary.Add(viewedChunkCoord, new TerrainChunk(viewedChunkCoord, chunkSize, transform));
    //             }
    //         }
    //     }
    // } 

    // public class TerrainChunk
    // {
    //     GameObject meshObject;
    //     Vector2 position;
    //     Bounds bounds;
    //     public TerrainChunk(Vector2 coord, int size) 
    //     {
    //         position = coord * size;
    //         bounds = new Bounds(position, Vector2.one * size);
    //         Vector3 positionV3 = new Vector3(position.x, 0, position.y);
    //         meshObject = GameObject.CreatePrimitive(PrimitiveType.Plane);
    //         meshObject.transform.position = positionV3;
    //         meshObject.transform.localScale = Vector3.one * size / 10f;
    //     }
    //     public void UpdateTerrainChunk()
    //     {
    //         float viewerDstFromNearestEdge = Mathf.Sqrt(bounds.SqrDistance(viewerPosition));
    //         bool visible = viewerDstFromNearestEdge <= maxViewDst;
    //         meshObject.SetActive(visible);
    //     }
    // }
}

//e07 10:19
