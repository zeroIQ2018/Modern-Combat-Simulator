using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class SelectUnit : MonoBehaviour
{
    int selectedx;
    int selectedy;
    public static bool selected;
    public Camera camera;
    float ys;
    float xs;
    float x;
    float y;
    


    void Start()
    {
        camera = Camera.main;
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
                Debug.Log($"{hit.collider.name} Detected",hit.collider.gameObject);
                if(selected == true){
                    x = hit.collider.transform.position.x;
                    y = hit.collider.transform.position.y;
                    Scenario1.myArray[(int)ys,(int)xs] = "E";
                    Scenario1.myArray[(int)y,(int)x] = "I";
                    selected = false;
                    
                }
                else{
                    xs = hit.collider.transform.position.x;
                    ys = hit.collider.transform.position.y;
                    selected = true;
                }
                

            }
        }

    }

    



}

