using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    void Update()
    {
        InputControl(); // ABSTRACTION
        Debug.Log("MovementSpeed : " + Unit.movementSpeed);
    }

    private void InputControl()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        transform.Rotate(new Vector3(0, 0, -horizontalInput) * Unit.movementSpeed * Time.deltaTime);

        if (Input.GetKey(KeyCode.Escape))
        {
            UIController.shapeToSave = null;
            SceneManager.LoadScene(0);
        }
    }
}
