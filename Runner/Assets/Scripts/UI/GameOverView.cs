using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverView : MonoBehaviour
{
    const string MAIN_SCENE = "Main";
	public void EndGame()
    {
        SceneManager.LoadScene(MAIN_SCENE);
    }
}
