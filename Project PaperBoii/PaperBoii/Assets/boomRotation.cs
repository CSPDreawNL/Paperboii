using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boomRotation : MonoBehaviour
{
    void Awake()
    {
        transform.rotation = Quaternion.Euler(0, 90, 0);
    }
}
