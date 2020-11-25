using System.Collections;
using System.Collections.Generic;
using UnityEngine.AddressableAssets;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    // Start is called before the first frame update
    public SpawnManagerScriptableObject SpawnManagerValue;
    public GameObject EntitesToSpawn;
    int instantiatenumber = 1;
    void Start()
    {
        SpawnEntities();
    }
    void SpawnEntities()
    {
        int CurrentSpawnIndex = 0;
        for(int i = 0; i < SpawnManagerValue.numberOfPrefabsToCreate; ++i)
        {
            GameObject currentSpawnEntites = Instantiate(EntitesToSpawn, SpawnManagerValue.spawnPoints[CurrentSpawnIndex], Quaternion.identity);
            currentSpawnEntites.name = SpawnManagerValue.prefabName + instantiatenumber;
            CurrentSpawnIndex = (CurrentSpawnIndex + 1) % SpawnManagerValue.spawnPoints.Length;

            ++instantiatenumber;
        }

    }

}
