using UnityEngine;

public abstract class Unit : MonoBehaviour
{
    public static int movementSpeed { get; set; } // ENCAPSULATION

    public virtual void MovementSpeed()
    {
        movementSpeed = 0; 
    }

    public void checkShape()
    {
        if (UIController.shapeToSave != gameObject.name)
        {
            Destroy(gameObject);
        }
    }
}
