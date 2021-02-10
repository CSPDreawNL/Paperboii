using UnityEngine;

public class TestMoneyAdder : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            StatManager.Instance.AddMoney(5);
        }
        else if (Input.GetKeyDown(KeyCode.S))
        {
            StatManager.Instance.LoseMoney(5);
        }
    }
}
