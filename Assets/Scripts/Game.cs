using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game : MonoBehaviour
{
    void Start()
    {
        var prefab = Resources.Load<GameObject>("Prefabs/Block");
        int x, z, i, j;
        for (i = 0; i < 5; i++)
        {
            z = 7 - i;
            for (j = 0; j < 13; j++)
            {
                x = -6 + j;
                Vector3 position = new Vector3(x, 1, z);
                Instantiate(prefab, position, Quaternion.identity);
            }
        }
    }

}
