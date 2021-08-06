using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class PlayerState 
{
    protected FollowEnemy parent;

    public virtual void Enter(FollowEnemy parent)
    {
        this.parent = parent;
    }
    
    public virtual void Update()
    {

    }
    public virtual void Exit()
    {

    }

    public virtual void OnTriggerEnter(Collider other)
    {

    }

    public virtual void OnTriggerExit(Collider other)
    {

    }
}
