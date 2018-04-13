using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour {

    public GameObject levelHolder;
    public const int X = 10;
    public const int Z = 12;
    public GameObject[,] level = new GameObject[X,Z];
        
        
	void Start ()
    {
        var objects = levelHolder.GetComponentsInChildren<Transform>();

        foreach (var child in objects)
        {
            level[(int)child.position.x, (int)child.position.z] = child.gameObject;
        }
        level[0, 0] = null;
    }
}
