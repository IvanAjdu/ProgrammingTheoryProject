using UnityEngine;
using UnityEngine.SceneManagement;

public class UIController : MonoBehaviour
{
    public static string shapeToSave { get; set; } // ENCAPSULATION

    public void SetSphere()
    {
        shapeToSave = "Sphere";
        StartMain(); // ABSTRACTION
    }
    public void SetSquare()
    {
        shapeToSave = "Cube";
        StartMain(); // ABSTRACTION
    }
    public void SetCapsule()
    {
        shapeToSave = "Capsule";
        StartMain(); // ABSTRACTION
    }

    private void StartMain()
    {
        Debug.Log(shapeToSave);
        SceneManager.LoadScene(1);
    }

}
