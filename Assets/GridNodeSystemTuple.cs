using System;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.InputSystem;

public class GridNodeSystemTuple : MonoBehaviour
{
    public List<Tuple<int, int>> node = new List<Tuple<int, int>>();
    public int gridsize =10;
    void Start()
    {
        for(int i = 0; i < gridsize; i++)
        {
            for (int i2 = 0; i2 < gridsize; i2++)
            {
            node.Add(new Tuple<int,int>(i,i2));
            }
        }
        foreach(var group in node)
        {
            Vector3 position = new Vector3(group.Item1 * 5, 0, group.Item2 * 5);
            GameObject cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
            cube.transform.position = position;
        }
    }
}
