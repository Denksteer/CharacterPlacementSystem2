using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class GridDrawScript : MonoBehaviour
{
    public int gridSize;
    public int cellSize;
    public float cellSpacing;
    public GameObject cell;
    public bool characterAlreadyHere;

    private void Start()
    {
        gridSize = 8;
        cellSize = 3;
        cellSpacing = 0.5f;
        GridPaint();
    }

    private void OnDrawGizmos()
    {
        for (int y = gridSize; y > 0; y--)
        {
            for (int x = gridSize; x > 0; x--)
            {
                Gizmos.DrawWireCube(
                    new Vector3(gameObject.transform.position.x + (x * cellSize), gameObject.transform.position.y + (y * cellSize)), 
                    new Vector3(cellSize, cellSize));
            }
        }
    }

    public void GridPaint()
    {
        for (int y = gridSize; y > 0; y--)
        {
            for (int x = gridSize; x > 0; x--)
            {
                GameObject currentCell = Instantiate(cell);
                currentCell.transform.position = new Vector3(x * cellSize, y * cellSize);
                currentCell.transform.localScale = new Vector3(cellSize, cellSize);
                currentCell.transform.SetParent(gameObject.transform, true);
                currentCell.name = x + "_" + y;
            }
        }
    }
}
