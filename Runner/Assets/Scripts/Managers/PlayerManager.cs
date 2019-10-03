using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    private GameObject player;

	void Start()
    {
        player = CurrentData.Instance.Model.CurrentPlayer.PlayerType;
        var playerObj = Instantiate(player,this.transform.position,Quaternion.identity);
        this.transform.SetParent(playerObj.transform);
    }
}
