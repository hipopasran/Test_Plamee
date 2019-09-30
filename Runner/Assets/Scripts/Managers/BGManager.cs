using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGManager : MonoBehaviour
{

    public MeshRenderer meshRenderer;
	void Awake()
    {
        meshRenderer = this.GetComponent<MeshRenderer>();
        meshRenderer.material.mainTexture = DataManager.instance.LevelData.Current.Background;
    }
}
