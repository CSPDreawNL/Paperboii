using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WegMovement : MonoBehaviour
{
    [Header("Options")]
    [SerializeField] private float moveForward;
    [SerializeField] private float moveRange;

    private void Start()
    {
        EventManager.current.playerMoved += Move;
    }

    private void Move(Vector3Int iPosition)
    {
        if (transform.position.x - iPosition.x < moveRange)
        {
            transform.position += new Vector3(moveForward, 0, 0);
        }
    }
}
