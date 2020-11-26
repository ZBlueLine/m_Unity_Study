using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class mouseTest : MonoBehaviour
{
    void OnMouseDown()
    {
        // Destroy the gameObject after clicking on it
        print("MouseDown!!");
        Destroy(gameObject);
    }
}