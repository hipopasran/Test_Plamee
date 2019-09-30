using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerPreview : MonoBehaviour
{
    [SerializeField]
    private Image preview;
    [SerializeField]
    private PlayersData Data;

    public void Update()
    {
        preview.sprite = Data.Current.Preview;
    }
}
