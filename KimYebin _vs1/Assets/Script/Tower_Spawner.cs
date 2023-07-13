using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tower_Spawner : MonoBehaviour
{
    public static Tower_Spawner instance;

    public List<GameObject> TowerPrefabs = new List<GameObject>();
    private void Awake()
    {
        instance = this;
    }
    void Start()
    {

    }

    void Update()
    {

    }
    public static void SpawnTower(GameObject tile)
    {
        instance._SpawnTower(tile);
    }
    private void _SpawnTower(GameObject tile)
    {
        var cur_tile = tile.GetComponent<Tile>();
        bool canBuild = cur_tile.tile_Info.isBuild;
        if (canBuild == false)
        {
            var tower = Instantiate(TowerPrefabs[0], tile.transform).GetComponent<Tower>();
            cur_tile.tile_Info.isBuild = true;
            cur_tile.tile_Info.tower_Info = tower.tower_Info;
        }
        else
        {
            Debug.Log("설치할 수 없다");
        }
    }
}
