using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementPlayerGrid : MonoBehaviour
{
    [Header("Positioning")]
    [SerializeField] private int LaneCount;
    [SerializeField] private float LaneSpacing;
    [SerializeField] private int startingLaneIndex;

    [Header("Dev Statistics")]
    [SerializeField] private List<Vector3> lanePositions = new List<Vector3>();
    [SerializeField] private int playerLaneIndex;

    private KeyBinds currentKeyBinds;

    private void Awake()
    {
        for (int i = 0; i < LaneCount; i++)
        {
            lanePositions.Add(new Vector3(0, 0, (-LaneCount / 2 + i + .5f) * LaneSpacing));
        }
    }

    private void Start()
    {
        EventManager.current.updateKeyBinds += UpdateKeyBinds;

        transform.position = lanePositions[GetNewPlayerLaneIndex(startingLaneIndex)];
    }

    private void Update()
    {
        if (Input.GetKeyDown(currentKeyBinds.moveLeft))
        {
            transform.position = lanePositions[GetNewPlayerLaneIndex(-1)];
        }

        if (Input.GetKeyDown(currentKeyBinds.moveRight))
        {
            transform.position = lanePositions[GetNewPlayerLaneIndex(1)];
        }
    }

    private int GetNewPlayerLaneIndex(int iDifference)
    {
        playerLaneIndex += iDifference;

        while (playerLaneIndex >= lanePositions.Count)
        {
            playerLaneIndex = lanePositions.Count - 1;
        }

        while (playerLaneIndex < 0)
        {
            playerLaneIndex = 0;
        }

        return playerLaneIndex;
    }

    private void UpdateKeyBinds(KeyBinds iKeyBinds)
    {
        currentKeyBinds = iKeyBinds;
    }
}
