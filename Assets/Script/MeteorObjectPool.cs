using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class MeteorObjectPool
{
    public static MeteorObjectPool Instance;
    public List<GameObject> meteorObjectPool;
    private GameObject prefabs;
    private int size;

    public MeteorObjectPool(GameObject _prefabs,int _size)
    {
        if (Instance != null)
        {
            return;
        }
        Instance = this;
        meteorObjectPool = new List<GameObject>();
        prefabs = _prefabs;
        size = _size;

        GrowPool();
    }

    private void GrowPool()
    {
        for (int i = 0; i < size; i++)
        {
            GameObject temp = GameObject.Instantiate(prefabs);
            temp.SetActive(false);
            meteorObjectPool.Add(temp);
        }
    }

    public GameObject GetObjectFromPool()
    {
        for (int i = 0; i < meteorObjectPool.Count; i++)
        {
            if (!meteorObjectPool[i].activeInHierarchy) 
            {
                return meteorObjectPool[i];
            }
        }
        GrowPool();

        return GetObjectFromPool();
    }

    public void ReturnObjectToPool(GameObject _activeObject)
    {
        _activeObject.SetActive(false);
    }


}
