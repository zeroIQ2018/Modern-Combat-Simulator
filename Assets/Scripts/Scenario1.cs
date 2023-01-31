using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Scenario1 : MonoBehaviour
{
    public GameObject _inf;
    public GameObject _Einf;
    public GameObject _FT;
    public GameObject _ET;

    public static string[,] myArray = new string[7, 5] 
    {
    { "FI", "FI", "E", "E", "E" },
    { "E", "E", "E", "FI", "FI" },
    { "E", "FI", "FI", "FI", "FI" },
    { "E", "FT", "FT", "FT", "FI" },
    { "FI", "FI", "FI", "FI", "E" },
    { "FI", "E", "E", "FI", "E" },
    { "E", "E", "E", "E", "E",}
};

    void Start()
    {
        CreateGame();
    }

    public void CreateGame()
    {
        for (int i = 0; i < myArray.GetLength(0); i++)
        {
            for (int j = 0; j < myArray.GetLength(1); j++)
            {
                if (myArray[i, j] == "FI")
                {
                    Instantiate( _inf, new Vector3(i, j, -0.1f), Quaternion.identity);
                }
                else if (myArray[i, j] == "EI")
                {
                    Instantiate(_Einf, new Vector3(i, j,  -0.1f),Quaternion.identity);
                }
                else if (myArray[i, j] == "FT")
                {
                    Instantiate(_FT, new Vector3(i, j, -0.1f),Quaternion.identity);
                }
                else if (myArray[i, j] == "ET")
                {
                    Instantiate(_ET, new Vector3(i, j,  -0.1f),Quaternion.identity);
                }
            }
        }
    }

}