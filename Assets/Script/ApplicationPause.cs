using UnityEngine;

public class ApplicationPause : MonoBehaviour
{
    bool isPaused = false;

    void OnGUI()
    {
        if (isPaused)
            GUI.Label(new Rect(100, 100, 50, 50), "Game paused");
    }

    void OnApplicationFocus(bool hasFocus)
    {
        isPaused = !hasFocus;
    }

    void OnApplicationPause(bool pauseStatus)
    {
        isPaused = pauseStatus;
    }
}