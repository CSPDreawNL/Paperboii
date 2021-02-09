using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementPlayerGrid : MonoBehaviour
{
    [Header("Positioning")]
    [SerializeField] private int LaneCount;
    [SerializeField] private float LaneSpacing;

    [Header("Dev Statistics")]
    [SerializeField] private List<Vector2> lanePositions = new List<Vector2>();
    [SerializeField] private int playerLaneIndex;

    private KeyBinds currentKeyBinds;

    private void Awake()
    {
        EventManager.current.updateKeyBinds += UpdateKeyBinds;

        for (int i = 0; i < LaneCount; i++)
        {
            lanePositions.Add(new Vector2(-LaneSpacing * (float)LaneCount / 2 + i + LaneSpacing / 2, 0));
        }
    }

    private void Update()
    {
        if (Input.GetKeyDown(currentKeyBinds.moveLeft))
        {
            transform.position += new Vector3(0, 0, GetNewPlayerLaneIndex(-1));
        }

        if (Input.GetKeyDown(currentKeyBinds.moveRight))
        {
            transform.position += new Vector3(0, 0, GetNewPlayerLaneIndex(1));
        }
    }

    private int GetNewPlayerLaneIndex(int iDifference)
    {
        int result = playerLaneIndex;

        result += iDifference;

        while (result >= lanePositions.Count)
        {
            result -= lanePositions.Count;
        }

        return result;
    }

    private void UpdateKeyBinds(KeyBinds iKeyBinds)
    {
        currentKeyBinds = iKeyBinds;
    }
}
