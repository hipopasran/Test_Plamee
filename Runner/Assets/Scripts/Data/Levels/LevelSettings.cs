using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(fileName ="New Level",menuName ="DataAboutLevel/LevelSettings")]
public class LevelSettings : ScriptableObject
{
    [SerializeField]
    private string levelName;
    [SerializeField]
    private float gravity;
    [SerializeField]
    private Sprite preview;
    [SerializeField]
    private Texture backgrounds;
    [SerializeField]
    private List<GameObject> obstacles;

    public string LevelName
    {
        get { return levelName; }
    }

    public float Gravity
    {
        get { return gravity; }
    }

    public Sprite Preview
    {
        get { return preview; }
    }

    public Texture Background
    {
        get { return backgrounds; }
    }

    public List<GameObject> Obstacles
    {
        get { return obstacles; }
    }
}
