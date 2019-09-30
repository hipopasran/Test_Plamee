using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pool
{

    public string tag;
    public GameObject prefab;
    public int size;

    public Pool(string _tag, GameObject _prefab, int _size)
    {
        tag = _tag;
        prefab = _prefab;
        size = _size;
    }
}
