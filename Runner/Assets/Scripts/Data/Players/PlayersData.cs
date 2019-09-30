using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Players", menuName = "DataAboutPlayer/PlayersData")]
public class PlayersData : ScriptableObject
{
    [SerializeField]
    private PlayerSettings current;
    [SerializeField]
    private List<PlayerSettings> players;

    public PlayerSettings Current
    {
        get { return current; }
        set { current = value; }
    }
    public List<PlayerSettings> Data
    {
        get { return players; }
    }
}
