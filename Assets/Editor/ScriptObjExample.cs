using UnityEngine;
using UnityEditor;
using UnityEngine.AddressableAssets;
using UnityEngine.ResourceManagement.AsyncOperations;

public class ScriptObjExample : ScriptableObject
{
    [MenuItem("GameObject/Create Material")]
    static void CreateMaterial()
    {
        // Create a simple material asset
        Material NewMaterial = new Material(Shader.Find("Specular"));
        AssetDatabase.CreateAsset(NewMaterial, "Assets/tMaterial.mat");
        Debug.Log(AssetDatabase.GetAssetPath(NewMaterial));
        //AsyncOperationHandle<GameObject> handle = Addressables.LoadAssetAsync<GameObject>("MyMaterial");
        //handle.Completed += Mygenerate;
        
    }

    static void Mygenerate(AsyncOperationHandle<GameObject> obj)
    {
    }
}