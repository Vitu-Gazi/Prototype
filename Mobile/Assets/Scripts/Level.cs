using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level : MonoBehaviour
{
    public int LevelNumber;
    public string Name;

    public Level NextLevel;

    public enum LevelState
    {
        Lock = 0,
        Open = 1,
        Win = 2
    }

    public LevelState State;
    private void Awake()
    {
        State = (LevelState)PlayerPrefs.GetInt(Name);
        Debug.Log(Name + " " + State);
        if (Name == "Level_1")
        {
            State = LevelState.Open;
        }
        else
        {
            State = LevelState.Lock;
        }
    }
    private void Start()
    {
        if (State == LevelState.Win)
        {
            NextLevel.State = LevelState.Open;
        }
        if (NextLevel == null)
        {

        }
        if (State == LevelState.Win)
        {
            gameObject.GetComponent<WinCub>().enabled = true;
        }
    }
}
