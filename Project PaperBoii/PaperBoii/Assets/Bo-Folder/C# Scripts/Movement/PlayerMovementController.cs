using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementController : MonoBehaviour
{
    [Header("Options")]
    [SerializeField] private Transform targetTrans;
    [SerializeField] private Movement movement;

    [SerializeField] private float movementSpeed;

    private TargetMovement tragetMovement;

    private void Start()
    {
        tragetMovement = new TargetMovement(transform, movement);
    }

    private void Update()
    {
        tragetMovement.Run(targetTrans, movementSpeed);
    }
}
