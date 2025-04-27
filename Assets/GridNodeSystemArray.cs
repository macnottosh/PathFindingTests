using UnityEngine;

public class GridNodeSystemArray : MonoBehaviour
{
    public int[] xNode = new int[10];
    public int[] zNode = new int [10];
    void Start()
    {
        for(int i = 0; i<10;i++)
        {
            xNode[i] = i;
            for (int i2 = 0; i2<10; i2++)
            {
                zNode[i2]=i2;
                Vector3 position = new Vector3(i * 5, 0, i2 * 5);
                GameObject cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
                cube.transform.position = position;
            }
        }
    }
}
