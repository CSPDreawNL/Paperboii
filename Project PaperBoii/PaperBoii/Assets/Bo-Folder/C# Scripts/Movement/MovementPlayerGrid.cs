using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementPlayerGrid : MonoBehaviour
{
    [Header("Positioning")]
    [SerializeField] private int LaneCount;

    private KeyBinds currentKeyBinds;

    private void Awake()
    {
        EventManager.current.updateKeyBinds += UpdateKeyBinds;
    }

    private void Update()
    {
        if (Input.GetKey(currentKeyBinds.moveLeft))
        {
            transform.position += new Vector3(0, 0, -1) * Time.deltaTime;
        }

        if (Input.GetKey(currentKeyBinds.moveRight))
        {
            transform.position += new Vector3(0, 0, 1) * Time.deltaTime;
        }
    }

    private void UpdateKeyBinds(KeyBinds iKeyBinds)
    {
        currentKeyBinds = iKeyBinds;
    }
}
