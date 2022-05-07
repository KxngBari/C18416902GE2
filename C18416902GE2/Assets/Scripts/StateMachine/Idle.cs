using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Idle : State
{
    public Flying chaseState;
    public bool canSeeShip;
    public override State RunCurrentState()
    {
        if (canSeeShip)
        {
            return chaseState;
        }
        else
        {

        }
        return this;
    }
}
