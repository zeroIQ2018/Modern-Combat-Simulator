using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class SelectUnit : MonoBehaviour
{
    int selectedx;
    int selectedy;
    public static bool selected;
    void Start()
    {

    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            CastRay();
        }

        void CastRay()
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit2D hit = Physics2D.Raycast(ray.origin, ray.direction, Mathf.Infinity);
            if (hit.collider != null)
            {
                float x = hit.collider.gameObject.transform.position.y;
                float y = hit.collider.gameObject.transform.position.x;
                if (selected == true)
                {
                    Scenario1.myArray[selectedy, selectedx] = "E";
                    Scenario1.myArray[(int)y, (int)x] = "I";
                    Debug.Log(x);
                    Debug.Log(y);
                    selected = false;
                }
                else if ("I" == Scenario1.myArray[(int)x, (int)y])
                {
                    x = selectedx;
                    y = selectedy;
                    selected = true;
                }
                    
                    
               
            }
        }
    }


}

