using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectDetector : MonoBehaviour
{
    private Camera mainCamera;
    private Ray ray;
    private RaycastHit hit;
    void Start()
    {
        mainCamera = Camera.main;
    }

    void Update()
    {
        Check_Screen();
    }
    void Check_Screen()
    {
        if (Input.GetMouseButtonDown(0))
        {
            ray = mainCamera.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out hit, Mathf.Infinity))
            {
                if (hit.transform.CompareTag("Tile"))
                {
                    var obj = hit.transform.gameObject;
                    Tower_Spawner.SpawnTower(obj);
                }
            }
        }
    }
}
