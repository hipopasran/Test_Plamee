using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Players", menuName = "DataAboutPlayer/PlayersData")]
public class PlayersData : ScriptableObject
{
    [SerializeField]
    private List<PlayerSettings> players;

    public IReadOnlyList<PlayerSettings> Data
    {
        get { return players; }
    }
}
