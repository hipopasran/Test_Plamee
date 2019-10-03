using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName ="Levels",menuName ="DataAboutLevel/Levels")]
public class LevelsData : ScriptableObject
{
    [SerializeField]
    private List<LevelSettings> levels;

    public IReadOnlyList<LevelSettings> Data
    {
        get { return levels; }
    }
}
