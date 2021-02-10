using UnityEngine;

public class EventManager
{
    // This EventManager
    public static EventManager current;

    // Delegates
    public delegate void keyBindDelegate(KeyBinds iKeyBinds);
    public delegate void Vector3IntDelegate(Vector3Int iVector3Int);

    // Events
    public event keyBindDelegate updateKeyBinds;
    public event Vector3IntDelegate playerMoved;

    public EventManager()
    {
        current = this;
    }

    public void UpdateKeyBinds(KeyBinds iKeyBinds)
    {
        if (updateKeyBinds != null)
        {
            updateKeyBinds(iKeyBinds);
        }
    }

    public void PlayerMoved(Vector3Int iVector3Int)
    {
        if (playerMoved != null)
        {
            playerMoved(iVector3Int);
        }
    }
}
