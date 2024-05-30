using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Tilemaps;


public class buildsystem : MonoBehaviour
{
    public Tilemap tilmap;
    public TileBase tilBase;
    public string tillname;
    public string tillnamestart;
    

    private void Start()
    {
        tilBase = Resources.Load<TileBase>(tillnamestart);
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.Mouse0))
        {
            Vector3 world = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            tilmap.SetTile(tilmap.WorldToCell(world), null);
        }

        if (Input.GetKey(KeyCode.Mouse1))
        {
            Vector3 world = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            tilmap.SetTile(tilmap.WorldToCell(world), tilBase);
        }

        
    }

    public void Onclick()
    {
        tilBase = Resources.Load<TileBase>(tillname);
    }
    
}
