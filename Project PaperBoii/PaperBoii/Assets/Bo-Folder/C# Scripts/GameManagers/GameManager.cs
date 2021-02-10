using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private KeyBinds standardKeyBinds = new KeyBinds(KeyCode.A, KeyCode.D, KeyCode.Space, KeyCode.Escape);

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
