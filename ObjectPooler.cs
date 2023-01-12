using System.Collections;
using UnityEngine;

public class ObjectPooler : MonoBehaviour
{
    public static ObjectPooler current;

    public Transform poolContent;

    private void Awake()
    {
        current = this;
    }

    void CreatePoolObjects()
    {
        
    }
}

[System.Serializable]
public class ObjectPool
{
    public string tag;
    public List<PoolObject> preafabs;
}

[System.Serializable]
public class PoolObject
{
    public GameObject prefab;
    public int maxAmount = 1;
}