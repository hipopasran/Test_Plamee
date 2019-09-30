using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChoisButtonLevels : MonoBehaviour {

    private LevelsData Data;

    void Awake()
    {
        Data = DataManager.instance.LevelData;
    }
    public void Next()
    {
        if (!CheckForNull)
        {
            var index = Data.Data.IndexOf(Data.Current);
            if (index + 1 >= Data.Data.Count)
            {
                Data.Current = Data.Data[0];
            }
            else
            {
                Data.Current = Data.Data[index + 1];
            }
        }
    }

    public void Last()
    {
        var index = Data.Data.IndexOf(Data.Current);
        if (index - 1 < 0)
        {
            Data.Current = Data.Data[Data.Data.Count - 1];
        }
        else
        {
            Data.Current = Data.Data[index - 1];
        }

    }

    private bool CheckForNull
    {
        get
        {
            if (Data.Current == null)
            {
                if (Data.Data.Count == 0 || Data.Data == null)
                {
                    return true;
                }
                Data.Current = Data.Data[0];
            }

            return false;
        }
    }
}
