using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameDirector : MonoBehaviour
{
    public GridManager gridManager;
    public MapGenerator mapGenerator;

    void Start()
    {
        Init();
    }

    public void Init()
    {
        StartGame();
    }

    private void StartGame()
    {
        gridManager.CreateGrid();
    }
}
