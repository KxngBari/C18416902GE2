using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flying : State
{
    public Shooting shootingState;
    public bool isInAttackRange;
    public override State RunCurrentState()
    {
        if (isInAttackRange)
        {
            return shootingState;
        }
        else
        {

        }
        return this;
    }
}
