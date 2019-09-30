using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    private GameObject player;

	void Start()
    {
        player = DataManager.instance.PlayerData.Current.PlayerType;
        var playerObj = Instantiate(player,this.transform.position,Quaternion.identity);
        this.transform.SetParent(playerObj.transform);
    }
}
