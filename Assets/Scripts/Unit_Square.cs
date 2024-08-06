using UnityEngine;

public class Unit_Square : Unit //INHERITANCE
{
    private void Awake()
    {
        checkShape();
    }

    private void Update()
    {
        MovementSpeed();
    }

    public override void MovementSpeed() //POLYMORPHISM
    {
        movementSpeed = 50;
    }
}