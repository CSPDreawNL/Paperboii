using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MiniGameAimMovement : MonoBehaviour
{
    [SerializeField] private Transform attachedTrans;
    [SerializeField] private RectTransform myTrans;

    void Update()
    {
        myTrans.position = Camera.main.WorldToScreenPoint(attachedTrans.position) + new Vector3(Mathf.Sin(Time.time) * 2 , Mathf.Sin(-Time.time / .5f)) * 100;
    }
}
