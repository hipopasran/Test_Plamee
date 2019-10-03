using System.Collections.Generic;
using UnityEngine;

public class ObjectPooler : MonoBehaviour
{
    private LevelSettings levelSetup;
    private Dictionary<string, Queue<GameObject>> poolDictionary;

    public List<Pool> Pools { get; private set; }

    void Start ()
    {
        levelSetup = CurrentData.Instance.Model.CurrentLevel;
        Pools = new List<Pool>();

        foreach(var obs in levelSetup.Obstacles)
        {
            Pools.Add(new Pool(obs.name,obs,5));
        }

        poolDictionary = new Dictionary<string, Queue<GameObject>>();

        foreach (Pool pool in Pools)
        {
            Queue <GameObject> objectPool = new Queue<GameObject>();


            for (int i = 0; i < pool.size; i++)
            {
                GameObject obj = Instantiate(pool.prefab);
                obj.SetActive(false);
                objectPool.Enqueue(obj);
            }

            poolDictionary.Add(pool.tag, objectPool);
        }
	}

    public GameObject SpawnFromPool(string tag, Vector3 position,Quaternion rotation)
    {
        if(!poolDictionary.ContainsKey(tag))
        {
            return null;
        }

        GameObject objectToSpawn = poolDictionary[tag].Dequeue();

        objectToSpawn.SetActive(true);
        objectToSpawn.transform.position = position;
        objectToSpawn.transform.rotation = rotation;

        poolDictionary[tag].Enqueue(objectToSpawn);

        return objectToSpawn;
    }
}
