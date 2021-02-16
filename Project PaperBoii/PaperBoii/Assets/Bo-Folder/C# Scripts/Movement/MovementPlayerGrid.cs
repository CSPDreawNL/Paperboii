using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementPlayerGrid : MonoBehaviour
{
    [Header("Positioning")]
    [SerializeField] private int LaneCount;
    [SerializeField] private float LaneSpacing;
    [SerializeField] private int startingLaneIndex;

    [Header("Options")]
    [SerializeField] private float forwardSpeed;

    [Header("Dev Statistics")]
    [SerializeField] private List<Vector3> lanePositions = new List<Vector3>();
    [SerializeField] private int playerLaneIndex;

    private KeyBinds currentKeyBinds;

    [SerializeField] Vector3Int prevPlayerPosition;

    private void Awake()
    {
        for (int i = 0; i < LaneCount; i++)
        {
            lanePositions.Add(new Vector3(0, 0, (-LaneCount / 2 + i) * LaneSpacing));
        }
    }

    private void Start()
    {
        EventManager.current.updateKeyBinds += UpdateKeyBinds;

        transform.position = lanePositions[GetNewPlayerLaneIndex(startingLaneIndex)];
    }

    private void Update()
    {
        transform.position += new Vector3(forwardSpeed, 0) * Time.deltaTime;

        if (Input.GetKeyDown(currentKeyBinds.moveLeft))
        {
            transform.position = lanePositions[GetNewPlayerLaneIndex(1)] + new Vector3(transform.position.x, 0);
        }

        if (Input.GetKeyDown(currentKeyBinds.moveRight))
        {
            transform.position = lanePositions[GetNewPlayerLaneIndex(-1)] + new Vector3(transform.position.x, 0);
        }

        Vector3Int playerPositionInt = new Vector3Int((int)(transform.position.x + .5f), (int)(transform.position.y + .5f), (int)(transform.position.z));

        if (prevPlayerPosition != playerPositionInt)
        {
            prevPlayerPosition = playerPositionInt;

            EventManager.current.PlayerMoved(playerPositionInt);
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
