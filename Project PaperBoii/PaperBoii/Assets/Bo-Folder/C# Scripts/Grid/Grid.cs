using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grid : MonoBehaviour
{
    [Header("Grid Dimentions")]
    [SerializeField] private int GridLaneCount;

    private List<List<GameObject>> grid = new List<List<GameObject>>();

    private void Awake()
    {
        for (int i = 0; i < GridLaneCount; i++)
        {
            grid.Add(new List<GameObject>());
        }
    }

    private void Start()
    {
        EventManager.current.playerMoved += CheckForCollision;
    }

    private void CheckForCollision(Vector3Int iPosition)
    {
        iPosition.z = iPosition.z + 2;

        if (iPosition.z >= 0 && iPosition.z < grid.Count)
        {
            for (int i = 0; i < grid[iPosition.z].Count; i++)
            {
                if (grid[iPosition.z][i] != null)
                {
                    if (grid[iPosition.z][i].transform.position.x == iPosition.x)
                    {
                        EventManager.current.OnPlayerDie();
                    }
                }
            }
        }
    }

    public void GridAddObject(GameObject iObject, int iGridLanePosition, bool iDoOrganize)
    {
        grid[iGridLanePosition].Add(iObject);
    }
}
