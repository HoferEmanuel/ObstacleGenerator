using System.Collections;
using UnityEngine;

public class ObjectPooler : MonoBehaviour
{
    public static ObjectPooler current;

    public Transform poolContent;

    public List<ObjectPool> pools;

    private void Awake()
    {
        current = this;

        GeneratePoolObjects();
    }

    void GeneratePoolObjects()
    {
        foreach(ObjectPool pool in pools)
        {
            pool.CreatePoolContent;

            foreach(PoolObject poolObj in pool.poolObjects)
            {
                for (int i = 0; i < poolObj.maxAmount; i++)
                {
                    GameObject currentPrefab = Instantiate(poolObj.prefab, pool.poolContent, Quaternion.identity);
                    currentPrefab.localPosition = Vector3.zero;
                    currentPrefab.localRotation = Quaternion.Euler(0,0,0);
                    currentPrefab.SetActive(false);
                }
            }
        }
    }

    void CreatePoolObject(GameObject targetObj, Vector3 targetPos, Vector3 targetRot, float sizeMultiply)
    {
        
        targetObj.SetActive(true);
    }

    void DisablePoolObject(GameObject targetObj)
    {
        targetObj.SetActive(false);
    }
}

[System.Serializable]
public class ObjectPool
{
    public string tag;
    public List<PoolObject> poolObjects;
    public Transform poolContent;

    public void CreatePoolContent()
    {
        Transform content = new Transform();
        poolContent = content;
    }
}

[System.Serializable]
public class PoolObject
{
    public GameObject prefab;
    public int maxAmount = 1;
}