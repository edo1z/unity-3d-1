using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game : MonoBehaviour
{
    void Start()
    {
        var prefab = Resources.Load<GameObject>("Prefabs/Block");
        var materials = new[] {
            Resources.Load<Material>("Materials/Block1"),
            Resources.Load<Material>("Materials/Block2"),
            Resources.Load<Material>("Materials/Block3"),
            Resources.Load<Material>("Materials/Block4"),
            Resources.Load<Material>("Materials/Block5"),
        };
        int x, z, i, j;
        for (i = 0; i < 5; i++)
        {
            z = 7 - i;
            for (j = 0; j < 13; j++)
            {
                x = -6 + j;
                Vector3 position = new Vector3(x, 1, z);
                GameObject block = Instantiate(prefab, position, Quaternion.identity);
                block.GetComponent<MeshRenderer>().material = materials[Random.Range(0, 5)];
            }
        }
    }
}

