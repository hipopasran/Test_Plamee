using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CurrentData
{
    private static CurrentData instance = new CurrentData();
    private CurrentData() { }

    public static CurrentData Instance
    {
        get { return instance; }
    }

    public GameModel Model { get; set; }
}
