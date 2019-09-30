using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour {

    public delegate void ClickAction();
    public static event ClickAction OnClicked;

    void Update()
    {
        if(Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
            if(touch.phase == TouchPhase.Began)
            {
                if (OnClicked != null)
                    OnClicked();
            }
        }
        else if(Input.GetKeyDown(KeyCode.Space))
        {
            if (OnClicked != null)
                OnClicked();
        }
    }


}
