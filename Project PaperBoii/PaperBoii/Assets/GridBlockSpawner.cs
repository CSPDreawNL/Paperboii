using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridBlockSpawner : MonoBehaviour
{
    [Header("Recourses")]
    [SerializeField] private GridObjectBlock testBlock;

    [Header("Positioning")]
    [SerializeField] private int LaneCount;
    [SerializeField] private float LaneSpacing;
    [SerializeField] private int SpawnHeight;

    [Header("BlockCollection")]
    [SerializeField] private List<GridObjectBlock> blockList;

    [Header("Dev Statistics")]
    [SerializeField] private int rowIndex = 0;

    private int prevSpawnPositionX = 0;

    void Start()
    {
        EventManager.current.playerMoved += Spawn;
    }

    private void SpawnRow(List<GameObject> iRow, int iSpawnPosition)
    {
        Debug.Log(iRow.Count);

        for (int laneIndex = 0; laneIndex < iRow.Count; laneIndex++)
        {
            if (iRow[laneIndex] != null)
            {
                Instantiate(iRow[laneIndex], new Vector3(iSpawnPosition + SpawnHeight, 0, (-LaneCount / 2 + laneIndex) * LaneSpacing), Quaternion.identity);
            }
        }
    }

    private void Spawn(Vector3Int iSpawnPosition)
    {
        if (prevSpawnPositionX != iSpawnPosition.x)
        {
            prevSpawnPositionX = iSpawnPosition.x;

            SpawnRow(testBlock.GetRowObjects(rowIndex), iSpawnPosition.x);

            if (rowIndex >= testBlock.GetLongestLane())
            {
                rowIndex = 0;
            }
            else
            {
                rowIndex++;
            }
        }
    }
}
