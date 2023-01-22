using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class SelectUnit : MonoBehaviour
{
    bool selected = false;
    public Camera camera;
    float ys;
    float xs;
    float x;
    float y;
    float bxs;
    float bys;
    int result;
    public GameObject _inf;
    string[,] GameArray = Scenario1.myArray;

    void Start()
    {
        camera = Camera.main;
    }

    void DestroyWithTag(string destroyTag)
    {
        GameObject[] destroyObject;
        destroyObject = GameObject.FindGameObjectsWithTag(destroyTag);
        foreach (GameObject oneObject in destroyObject)
            Destroy(oneObject);
    }




    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = camera.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit))
            {
                if (hit.collider != null)
                {
                    Debug.Log($"{hit.collider.name} Detected", hit.collider.gameObject);
                    if (selected == true)
                    {

                        x = hit.collider.transform.position.x;
                        y = hit.collider.transform.position.y;
                        if (GameArray[(int)x, (int)y] == "E")
                        {
                            if (Mathf.Abs(xs - x) <= 1 && Mathf.Abs(ys - y) <= 1)
                            {
                                GameArray[(int)xs, (int)ys] = "E";
                                GameArray[(int)x, (int)y] = "I";
                                DestroyWithTag(("FieldObject"));
                                CreateGame();
                                selected = false;

                            }
                        }




                    }
                    if (selected == false)
                    {
                        bxs = hit.collider.transform.position.x;
                        bys = hit.collider.transform.position.y;
                        if (GameArray[(int)bxs, (int)bys] != "E")
                        {
                            xs = hit.collider.transform.position.x;
                            ys = hit.collider.transform.position.y;
                            selected = true;
                        }


                    }
                    Debug.Log(selected);
                }
            }

        }


        void CreateGame()
        {
            for (int i = 0; i < GameArray.GetLength(0); i++)
            {
                for (int j = 0; j < GameArray.GetLength(1); j++)
                {
                    if (GameArray[i, j] == "I")
                    {
                        Instantiate(_inf, new Vector3(i, j, -0.1f), Quaternion.identity);
                    }
                }
            }
        }
    }
}
