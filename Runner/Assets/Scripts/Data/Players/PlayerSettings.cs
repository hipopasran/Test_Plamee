using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(fileName = "New Player", menuName = "DataAboutPlayer/PlayerSettings")]
public class PlayerSettings : ScriptableObject
{
    [SerializeField]
    private string playerName;
    [SerializeField]
    private Sprite preview;
    [SerializeField]
    private GameObject playerType;

    public string PlayerName
    {
        get { return playerName; }
    }

    public Sprite Preview
    {
        get { return preview; }
    }

    public GameObject PlayerType
    {
        get { return playerType; }
    }
	
}
