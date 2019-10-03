using System.Collections;
using UnityEngine;

[RequireComponent(typeof(ObjectPooler))]
public class ObstacleSpawner : MonoBehaviour
{
    [SerializeField]
    private Transform Spawn;
    [SerializeField]
    private float delayTime;

    private float counter = 0;
    private bool doSpawn;

    private ObjectPooler objectPooler;

    void Start()
    {
        objectPooler = GetComponent<ObjectPooler>();
    }

    void Update()
    {
        if (!doSpawn)
        {
            StartCoroutine(Wait());
        }
        
        if(counter > delayTime && doSpawn)
        {
            counter = 0;
            int rnd = Random.Range(0, objectPooler.Pools.Count);
            objectPooler.SpawnFromPool(objectPooler.Pools[rnd].tag, Spawn.position, Quaternion.identity);
            doSpawn = false;
            if (delayTime > 1.8f)
            {
                delayTime -= 0.1f;
            }
        }
        counter += Time.deltaTime;
    }

    private IEnumerator Wait()
    {
        yield return new WaitForSeconds(delayTime);
        doSpawn = true;
    }
}
