using UnityEngine;

public class PlayerFollower : MonoBehaviour
{
    [SerializeField]
    private Transform player;

    private Vector3 offset;
        
    void Start()
    {
        offset = transform.position - player.position;
    }

    void LateUpdate()
    {
        transform.position = new Vector3(player.position.x + offset.x,this.transform.position.y,this.transform.position.z);
    }
}
