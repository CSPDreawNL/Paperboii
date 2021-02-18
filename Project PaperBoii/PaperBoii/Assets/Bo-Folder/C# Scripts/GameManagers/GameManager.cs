using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private KeyBinds standardKeyBinds = new KeyBinds(KeyCode.Mouse0, KeyCode.Mouse1, KeyCode.Space, KeyCode.Escape);

    private void Awake()
    {
        new EventManager();
        new ExtraMath();
    }

    void Start()
    {
        EventManager.current.UpdateKeyBinds(standardKeyBinds);
    }
}
