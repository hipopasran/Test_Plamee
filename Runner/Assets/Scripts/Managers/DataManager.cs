using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DataManager : MonoBehaviour {

    public static DataManager instance = null;

    [SerializeField]
    private PlayersData playerData;
    [SerializeField]
    private LevelsData levelData;

    public PlayersData PlayerData
    {
        get { return playerData; }
    }

    public LevelsData LevelData
    {
        get { return levelData; }
    }

    void Awake()
    {
        if(instance == null)
        {
            instance = this;
        }
        else if(instance != this)
        {
            Destroy(gameObject);
        }

        DontDestroyOnLoad(gameObject);
    }
	

}
