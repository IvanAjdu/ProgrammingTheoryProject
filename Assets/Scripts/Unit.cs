using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Unit : MonoBehaviour
{
    public static int movementSpeed;

    public virtual void MovementSpeed()
    {
        movementSpeed = 0;
    }
}
