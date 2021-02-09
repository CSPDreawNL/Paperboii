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

    public void GridAddObject(GameObject iObject, int iGridLanePosition, bool iDoOrganize)
    {
        grid[iGridLanePosition].Add(iObject);

        if (iDoOrganize)
        {
            GridLaneOrganize(iGridLanePosition);
        }
    }

    public void GridLaneOrganize(int iGridLanePosition)
    {
        //List<GameObject> curLaneList = grid[iGridLanePosition];
        //List<GameObject> resultList = new List<GameObject>();

        //if (curLaneList.Count >= 1)
        //{
        //    resultList[0] = curLaneList[0];
        //}

        //for (int i = 1; i < curLaneList.Count; i++)
        //{
        //    if (curLaneList[i].transform.position.x < curLaneList[i].transform.position.x)
        //    {

        //    }
        //}
    }
}
