using System.Collections.Generic;
using UnityEngine;

public class GridNodeSystemDictionary : MonoBehaviour
{
    public Dictionary<string, (int,int)> nodes = new Dictionary<string, (int, int)>();
    int counter = 0;
    void Start()
    {
        for(int i = 0; i<10; i++)
        {
            for(int i2 = 0; i2<10;i2++)
            {
                nodes.Add("Node:"+counter+":",(i,i2));
                counter++;
                Vector3 position = new Vector3(i * 5, 0, i2 * 5);
                GameObject cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
                cube.transform.position = position;

                
            }
        }
    }
}
