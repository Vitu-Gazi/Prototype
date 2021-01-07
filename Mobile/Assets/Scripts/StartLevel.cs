using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartLevel : MonoBehaviour
{
    Level level;

    private void Start()
    {
        level = GetComponent<Level>();
    }

    private void OnMouseDown()
    {
        if (level.State == Level.LevelState.Open || level.State == Level.LevelState.Win)
        {
            SceneManager.LoadScene(level.Name);
        }
    }
}
