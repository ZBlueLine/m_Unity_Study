using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fractal : MonoBehaviour
{
    [SerializeField]
    Mesh MyMesh;
    [SerializeField]
    Material MyMaterial;

    [SerializeField, Range(0.0f, 1.0f)]
    float ChildScale;
    static int MaxDeep = 20;
    int currentDeep;
    void Start()
    {
        gameObject.AddComponent<MeshFilter>().mesh = MyMesh;
        gameObject.AddComponent<MeshRenderer>().material = MyMaterial;
        if(currentDeep >= MaxDeep)return;
        new GameObject("Fractal Child").AddComponent<Fractal>().initilize(this, Vector3.up);
        new GameObject("Fractal Child").AddComponent<Fractal>().initilize(this, Vector3.right);

    }

    void initilize(Fractal parent, Vector3 direction)
    {
        transform.parent = parent.transform;
        currentDeep = parent.currentDeep + 1;
        ChildScale = parent.ChildScale;
        MyMesh = parent.MyMesh;
        MyMaterial = parent.MyMaterial;
        transform.localPosition = direction * (0.5f + 0.5f * ChildScale);
        transform.localScale = ChildScale * Vector3.one;
    }

    // Update is called once per frame
}
