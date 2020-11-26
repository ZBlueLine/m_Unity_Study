using UnityEngine;
[CreateAssetMenu(fileName = "Data", menuName = "ScriptableObjects/SpawnManagerScriptableObject", order = 1)]
public class SpawnManagerScriptableObject  : ScriptableObject
{
    // Start is called before the first frame update
    public string prefabName = "init";
    public int numberOfPrefabsToCreate;
    public Vector3[] spawnPoints;
}
