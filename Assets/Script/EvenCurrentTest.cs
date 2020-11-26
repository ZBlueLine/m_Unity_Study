using UnityEngine;

public class EvenCurrentTest : MonoBehaviour
{
    void OnGUI()
    {
        if(GUILayout.Button("A Button"))
            Debug.Log("Current detected event: " + Event.current);
    }
}