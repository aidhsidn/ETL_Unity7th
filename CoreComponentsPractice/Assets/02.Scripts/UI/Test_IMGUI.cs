using UnityEngine;

public class Test_IMGUI : MonoBehaviour
{
    void OnGUI()
    {
        // Make a background box
        GUI.Box(new Rect(10, 10, 100, 90), "Loader Menu");

        // Make the first button. If it is pressed, Application.Loadlevel (1) will be executed
        if (GUI.Button(new Rect(20, 40, 80, 20), "Level 1"))
        {
            Debug.Log("Clicked Level 1");
        }

        // Make the second button.
        if (GUI.Button(new Rect(20, 70, 80, 20), "Level 2"))
        {
            Debug.Log("Clicekd Level 2");
        }
    }
}
