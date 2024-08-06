using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Unit_Square : Unit
{
    private void Awake()
    {
        checkShape();
        MovementSpeed();
    }

    public override void MovementSpeed()
    {
        movementSpeed = 50;
    }
}