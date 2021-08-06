using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IdleState : PlayerState
{

   public override void Update()
    {
        if (parent.DefaultRotation != parent.Rotator.rotation)
        {
            parent.Rotator.rotation = Quaternion.RotateTowards(parent.Rotator.rotation, parent.DefaultRotation, Time.deltaTime * parent.RotationSpeed);
        }

        if (parent.Target != null)
        {
            if (parent.CanSeeTarget(((parent.Target.position + parent.AimOffset) - parent.GunBarrels[0].position), parent.GunBarrels[0].position, "Enemy"))
            {
                parent.ChangeState(new FindTargetState());
            }
        }
    }

   public override void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Enemy")
        {
            parent.Target = other.transform;
            parent.ChangeState(new FindTargetState());
        }
    }
}
