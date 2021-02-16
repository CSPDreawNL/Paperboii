using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleController : MonoBehaviour
{
    [Header("Options")]
    [SerializeField] private int despawnRange;

    Transform mytrans;

    private void Awake()
    {
        mytrans = transform;
    }

    void Start()
    {
        EventManager.current.playerMoved += DespawnOnRange;
    }

    private void DespawnOnRange(Vector3Int iPosition)
    {
        if (iPosition.x > mytrans.position.x + despawnRange)
        {
            EventManager.current.playerMoved -= DespawnOnRange;

            Destroy(gameObject);
        }
    }
}
