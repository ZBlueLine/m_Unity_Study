using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.ResourceManagement.AsyncOperations;

public class AddressTest : MonoBehaviour
{
    public int MeshSelect = 1;
    string selectLabel = "C1";
    public AssetReference AAsset;
    void Start()
    {
        selectLabel = MeshSelect != 1 ? "C2" :"C1";
        // Prints the tag that this transform has 
        /*        print("Transform Tag is: " + gameObject.tag);*/
        /*Addressables.InstantiateAsync("MyCapsule");*/
        //AsyncOperationHandle<GameObject> handle = Addressables.LoadAssetAsync<GameObject>("Capsule");
        //AsyncOperationHandle<GameObject> handle = Addressables.LoadAssetAsync<GameObject>(selectLabel);
        AsyncOperationHandle<GameObject> handle = Addressables.LoadAssetAsync<GameObject>(AAsset);
        handle.Completed += OnLoadDown;
    }

    void OnLoadDown(UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<GameObject> obj)
    {
        Addressables.Release(obj);
        if (obj.Status == AsyncOperationStatus.Succeeded)
        {
            print("Loading complete");
            Instantiate(obj.Result, transform.position, Quaternion.identity);
        }
        else
            print("Loading Failed");
    }
}