using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public enum Tower_Kind
{
    Cannon
}
[System.Serializable]
public class Tower_Info 
{
    public Tower_Kind tower_Kind;
    public int tower_Lv;
    public float tower_Dmg;
    public float tower_Delay;
}
public class Tower : MonoBehaviour
{
    public Tower_Info tower_Info;
    void Start()
    {

    }

    void Update()
    {

    }
}
