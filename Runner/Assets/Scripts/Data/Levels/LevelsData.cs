using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName ="Levels",menuName ="DataAboutLevel/Levels")]
public class LevelsData : ScriptableObject
{
    [SerializeField]
    private LevelSettings current;
    [SerializeField]
    private List<LevelSettings> levels;

    public LevelSettings Current
    {
        get { return current; }
        set { current = value; }
    }

    public List<LevelSettings> Data
    {
        get { return levels; }
    }
	
}
