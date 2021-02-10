using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "GridObjectBlock", menuName = "GridObjectBlock")]
public class GridObjectBlock : ScriptableObject
{
    [Header("Block Information")]
    [SerializeField] public List<GameObject> Lane0 = new List<GameObject>();
    [SerializeField] public List<GameObject> Lane1 = new List<GameObject>();
    [SerializeField] public List<GameObject> Lane2 = new List<GameObject>();
    [SerializeField] public List<GameObject> Lane3 = new List<GameObject>();
    [SerializeField] public List<GameObject> Lane4 = new List<GameObject>();

    public List<List<GameObject>> GetAllLanes()
    {
        List<List<GameObject>> result = new List<List<GameObject>>();

        result.Add(Lane0);
        result.Add(Lane1);
        result.Add(Lane2);
        result.Add(Lane3);
        result.Add(Lane4);

        return result;
    }

    public List<GameObject> GetRowObjects(int iRowIndex)
    {
        List<GameObject> result = new List<GameObject>();

        List<List<GameObject>> lanes = GetAllLanes();

        for (int i = 0; i < lanes.Count; i++)
        {
            if (lanes[i].Count > iRowIndex)
            {
                result.Add(lanes[i][iRowIndex]);
            }
            else
            {
                result.Add(null);
            }
        }

        return result;
    }

    public int GetLongestLane()
    {
        int result = 0;

        List<List<GameObject>> lanes = GetAllLanes();

        for (int i = 0; i < lanes.Count; i++)
        {
            if (lanes[i].Count > result)
            {
                result = lanes[i].Count;
            }
        }

        return result;
    }
}
