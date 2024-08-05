using UnityEngine;

public class PlayerController : MonoBehaviour
{
    void Update()
    {
        InputControl();
        Debug.Log("MovementSpeed : " + Unit.movementSpeed);
    }

    private void InputControl()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        transform.Rotate(new Vector3(0, 0, -horizontalInput) * Unit.movementSpeed * Time.deltaTime);
    }
}
