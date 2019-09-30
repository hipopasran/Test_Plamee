using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelPreview : MonoBehaviour
{
    [SerializeField]
    private Image preview;
    [SerializeField]
    private LevelsData Data;

    public void Update()
    {
        preview.sprite = Data.Current.Preview;
    }
}
