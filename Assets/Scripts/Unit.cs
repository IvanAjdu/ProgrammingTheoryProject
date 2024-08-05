using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Unit : MonoBehaviour
{
    public static int movementSpeed { get; set; }

    public virtual void MovementSpeed()
    {
        movementSpeed = 0;
    }
}
