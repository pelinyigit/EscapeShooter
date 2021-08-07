using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FindTargetState : PlayerState
{
    public override void Update()
    {
        parent.GhostRotator.LookAt(parent.Target.position + parent.AimOffset);

        parent.Rotator.rotation = Quaternion.RotateTowards(parent.Rotator.rotation, parent.GhostRotator.rotation, Time.deltaTime * parent.RotationSpeed);

        if (parent.GhostRotator.rotation.y == parent.Rotator.rotation.y)
        {
            parent.ChangeState(new ShootEnemyState());
        }
    }

    //public override void OnTriggerExit(Collider other)
    //{
    //    if (other.tag == "Enemy")
    //    {
    //        parent.Target = null;
    //        parent.ChangeState(new IdleState());
    //    }
    //}
}
