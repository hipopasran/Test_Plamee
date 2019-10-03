using UnityEngine;

public class EnvironmentManager : MonoBehaviour
{

    private float gravity;
	void Awake()
    {
        gravity = CurrentData.Instance.Model.CurrentLevel.Gravity;
        Physics2D.gravity = new Vector2(0, gravity);
    }
}
