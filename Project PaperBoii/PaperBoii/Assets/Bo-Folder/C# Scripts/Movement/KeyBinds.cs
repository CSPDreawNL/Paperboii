using UnityEngine;

public class KeyBinds
{
    [Header("Player Movement")]
    [SerializeField] public KeyCode moveLeft;
    [SerializeField] public KeyCode moveRight;

    [Header("Player Actions")]
    [SerializeField] public KeyCode throwPaper;

    [Header("Game Actions")]
    [SerializeField] public KeyCode gamePauze;

    public KeyBinds(KeyCode iMoveLeft, KeyCode iMoveRight, KeyCode iThrowPaper, KeyCode iGamePauze)
    {
        moveLeft = iMoveLeft;
        moveRight = iMoveRight;
        throwPaper = iThrowPaper;
        gamePauze = iGamePauze;
    }

    public KeyBinds()
    {

    }
}
