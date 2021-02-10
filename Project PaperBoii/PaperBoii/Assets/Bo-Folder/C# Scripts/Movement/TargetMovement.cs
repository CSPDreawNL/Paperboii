using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetMovement
{
    private Movement movement;
    private Targeting targeting = new Targeting();
    private Transform mytrans;

    public TargetMovement(Transform iMytrans, Movement iMovement)
    {
        mytrans = iMytrans;
        movement = iMovement;
    }

    public void Run(Transform iTargetTransform, float iMovementSpeed)
    {
        MoveToTarget(iTargetTransform, iMovementSpeed);
    }

    public void Run(string iTargetTag, float iMovementSpeed)
    {
        GameObject target = targeting.GetNearestTag(iTargetTag, mytrans.position);

        if (target != null)
        {
            MoveToTarget(target.transform, iMovementSpeed);
        }
    }

    private void MoveToTarget(Transform iTargetTransform, float iMovementSpeed)
    {
        Vector3 velocity = ExtraMath.current.ClampedVector3Lerp(mytrans.position, iTargetTransform.position, iMovementSpeed);

        movement.SetDisiredVelocity(velocity);
    }
}
