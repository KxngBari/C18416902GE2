using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Idle : State
{
    public override State RunCurrentState()
    {
        return this;
    }
}