using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Tile_Info
{
    public bool isBuild = false;
    public Tower_Info tower_Info;
}
public class Tile : MonoBehaviour
{
    public Tile_Info tile_Info = new Tile_Info();
    void Start()
    {

    }

    void Update()
    {

    }
}
