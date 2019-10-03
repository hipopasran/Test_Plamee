using UnityEngine;

[RequireComponent(typeof(MeshRenderer))]
public class BGManager : MonoBehaviour
{
    private MeshRenderer meshRenderer;

	void Awake()
    {
        meshRenderer = this.GetComponent<MeshRenderer>();
        meshRenderer.material.mainTexture = CurrentData.Instance.Model.CurrentLevel.Background;
    }
}
