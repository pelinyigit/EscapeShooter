using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootEnemyState : PlayerState
{
   public override void Enter(FollowEnemy parent)
    {
        base.Enter(parent);
        parent.Animator.SetBool("Shoot", true);
    }

   public override void Update()
    {
        if (parent.Target != null)
        {
            parent.Rotator.LookAt(parent.Target.position + parent.AimOffset);
        }
        if (!parent.CanSeeTarget(parent.GunBarrels[0].forward, parent.Rotator.position, "Enemy"))
        {
            parent.ChangeState(new IdleState());
        }
    }
}
