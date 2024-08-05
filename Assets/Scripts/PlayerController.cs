using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] float movementSpeed = 250f;


    void Update()
    {
        InputControl();
    }

    private void InputControl()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        transform.Rotate(new Vector3(0, horizontalInput, 0) * movementSpeed * Time.deltaTime);
    }
}
