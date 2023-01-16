using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Scenario1 : MonoBehaviour
{
    public GameObject _inf;
    public static string[,] myArray = new string[6, 5] 
    {
    { "I", "I", "E", "E", "E" },
    { "E", "E", "E", "I", "I" },
    { "E", "I", "I", "I", "E" },
    { "E", "E", "E", "I", "I" },
    { "I", "I", "I", "I", "E" },
    { "I","E","E", "I","E" },
};

    void Start()
    {
        CreateGame();
    }

    void Update()
    {
        if (SelectUnit.selected == true)
        {
            CreateGame();
        }
    }
    public void CreateGame()
    {
        for (int i = 0; i < myArray.GetLength(0); i++)
        {
            for (int j = 0; j < myArray.GetLength(1); j++)
            {
                if (myArray[i, j] == "E")
                {
                    Instantiate( _inf, new Vector3(i, j, 0), Quaternion.identity);
                }
            }
        }
    }

}