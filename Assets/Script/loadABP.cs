using UnityEngine;
using System.Collections;
using System.IO;

public class loadABP : MonoBehaviour
{
    string path = "Assets/AssetBundles/myabpack";
    IEnumerator LoadFromMemoryAsync(string path)
    {
        AssetBundleCreateRequest createRequest = AssetBundle.LoadFromMemoryAsync(File.ReadAllBytes(path));
        yield return createRequest;
        AssetBundle bundle = createRequest.assetBundle;
        string[] name = bundle.GetAllAssetNames();
        foreach(string s in name)
        {
            print(s);
        }
        var prefab = bundle.LoadAsset<GameObject>("Capsule");
        Instantiate(prefab);
    }

    private void Start()
    {
        StartCoroutine(LoadFromMemoryAsync(path));
    }
}