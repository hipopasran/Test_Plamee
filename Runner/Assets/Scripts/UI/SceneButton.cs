using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneButton : MonoBehaviour {

    public void PressButton(string levelName)
    {
        GameManager.instance.LoadLevel(levelName);
    }
}
