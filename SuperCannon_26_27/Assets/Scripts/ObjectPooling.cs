using System.Collections.Generic;
using UnityEngine;

public class ObjectPooling : MonoBehaviour
{
    public GameObject objectToPool;
    public int poolSize;

    private List<GameObject> pooledObjects;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        pooledObjects = new List<GameObject>();
        GameObject tmp;

        for (int i=0; i < poolSize; i++)
        {
            tmp = Instantiate(objectToPool);
            tmp.SetActive(false);
            tmp.transform.SetParent(this.transform);
            pooledObjects.Add(tmp);
        }
    }

    public GameObject GetPoolObject()
    {
        for (int i=0; i < poolSize; i++)
        {
            if (!pooledObjects[i].activeInHierarchy) return pooledObjects[i];
        }
        return null;
    }
}

