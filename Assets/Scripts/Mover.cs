/* using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    public char[,] gameBoard = { {'E', 'E', 'E'},
                                {'E', 'I', 'E'},
                                {'E', 'E', 'E'} };

    // Prefab to be moved on the game board
    public GameObject prefab;

    // Position of the selected tile
    private Vector2 selectedTile = new Vector2(-1, -1);

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            // Get the mouse click position and convert it to a tile position
            Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Vector2 tilePos = new Vector2(Mathf.RoundToInt(mousePos.x), Mathf.RoundToInt(mousePos.y));

            // Check if the clicked tile is empty
            if (gameBoard[(int)tilePos.x, (int)tilePos.y] == 'E')
            {

                // If a tile is already selected, move the prefab to this tile
                else
                {
                    // Check if the selected tile is adjacent to the clicked tile
                    if (Mathf.Abs(selectedTile.x - tilePos.x) <= 1 && Mathf.Abs(selectedTile.y - tilePos.y) <= 1)
                    {
                        // Move the prefab to the clicked tile
                        prefab.transform.position = new Vector3(tilePos.x, tilePos.y, 0);
                        // Update the game board
                        gameBoard[(int)tilePos.x, (int)tilePos.y] = 'I';
                        gameBoard[(int)selectedTile.x, (int)selectedTile.y] = 'E';
                        // Deselect the selected tile
                        selectedTile = new Vector2(-1, -1);
                    }
                }
            }
        }
    }
}
}
*/ 