using UnityEngine;

public class EventManager
{
    public static EventManager current;

    public delegate void keyBindDelegate(KeyBinds iKeyBinds);
    public event keyBindDelegate updateKeyBinds;

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
}
