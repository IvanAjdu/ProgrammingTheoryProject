using UnityEngine;
using UnityEngine.SceneManagement;

public class UIController : MonoBehaviour
{
    public static string shapeToSave { get; set; }

    public void SetSphere()
    {
        shapeToSave = "Sphere";
        StartMain();
    }
    public void SetSquare()
    {
        shapeToSave = "Cube";
        StartMain();
    }
    public void SetCapsule()
    {
        shapeToSave = "Capsule";
        StartMain();
    }

    private void StartMain()
    {
        Debug.Log(shapeToSave);
        SceneManager.LoadScene(1);
    }

}
