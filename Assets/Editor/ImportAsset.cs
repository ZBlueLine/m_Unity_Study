using UnityEngine;
using UnityEditor;

public class ImportAsset
{
    [MenuItem("AssetDatabase/ImportExample")]
    static void ImportExample()
    {
        AssetDatabase.ImportAsset("Assets/Textures/texture.png", ImportAssetOptions.Default);
        
    }
}
