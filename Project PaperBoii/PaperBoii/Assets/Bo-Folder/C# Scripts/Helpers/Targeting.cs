using UnityEngine;

public class Targeting
{
    public GameObject GetNearestTag(string itag, Vector3 iPosition)
    {
        GameObject nearestObject = null;
        float nearestDistance = float.MaxValue;

        GameObject[] objects = GameObject.FindGameObjectsWithTag(itag);

        for (int i = 0; i < objects.Length; i++)
        {
            GameObject curObject = objects[i];

            float distance = GetDistance(iPosition, curObject.transform.position);

            if (distance < nearestDistance)
            {
                nearestDistance = distance;
                nearestObject = curObject;
            }
        }

        return nearestObject;
    }

    private float GetDistance(Vector3 iPositionA, Vector3 iPositionB)
    {
        return (iPositionA - iPositionB).magnitude;
    }
}
