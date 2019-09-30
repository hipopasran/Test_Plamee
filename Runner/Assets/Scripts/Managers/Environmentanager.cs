using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Environmentanager : MonoBehaviour {

    private float gravity;
	void Awake()
    {
        gravity = DataManager.instance.LevelData.Current.Gravity;
        Physics2D.gravity = new Vector2(0, gravity);
    }
}
