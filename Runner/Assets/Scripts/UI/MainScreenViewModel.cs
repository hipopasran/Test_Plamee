using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainScreenViewModel : MonoBehaviour
{
    const string GAME_SCENE = "Game";

    [SerializeField]
    private PlayersData playerData;
    [SerializeField]
    private LevelsData levelData;

    [SerializeField]
    private Image playerPreview;
    [SerializeField]
    private Image levelPreview;

    private int currentPlayerIndex;
    private int currentLevelIndex;

    void Awake()
    {
        playerPreview.sprite = playerData.Data[currentPlayerIndex].Preview;
        levelPreview.sprite = levelData.Data[currentLevelIndex].Preview;
    }

    private int Next<T>(IReadOnlyList<T> list, int index)
    {
        if (index + 1 >= list.Count)
        {
            index = 0;
        }
        else
        {
            index += 1;
        }

        return index;
    }

    private int Last<T>(IReadOnlyList<T> list, int index)
    {
        if (index - 1 < 0)
        {
            index = list.Count - 1; ;
        }
        else
        {
            index -= 1;
        }

        return index;
    }

    public void NextPlayer()
    {
        currentPlayerIndex = Next(playerData.Data, currentPlayerIndex);
        playerPreview.sprite = playerData.Data[currentPlayerIndex].Preview;
    }

    public void LastPlayer()
    {
        currentPlayerIndex = Last(playerData.Data, currentPlayerIndex);
        playerPreview.sprite = playerData.Data[currentPlayerIndex].Preview;
    }

    public void NextLevel()
    {
        currentLevelIndex = Next(levelData.Data, currentLevelIndex);
        levelPreview.sprite = levelData.Data[currentLevelIndex].Preview;
    }

    public void LastLevel()
    {
        currentLevelIndex = Last(levelData.Data, currentLevelIndex);
        levelPreview.sprite = levelData.Data[currentLevelIndex].Preview;
    }

    public void StartGame()
    {
        CurrentData.Instance.Model = new GameModel(playerData.Data[currentPlayerIndex], levelData.Data[currentLevelIndex]);
        SceneManager.LoadScene(GAME_SCENE);
    }
}
