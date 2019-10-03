using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameModel
{
    public GameModel(PlayerSettings currentPlayer, LevelSettings currentLevel)
    {
        this.CurrentLevel = currentLevel;
        this.CurrentPlayer = currentPlayer;
    }
    public LevelSettings CurrentLevel { get; private set; }

    public PlayerSettings CurrentPlayer { get; private set; }
}
