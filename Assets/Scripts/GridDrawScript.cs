using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class GridDrawScript : MonoBehaviour
{
    public int gridSize;
    public int cellSize;
    
    public CellCheck cell;
    public CellCheck[,] cellGrid;

    private void Start()
    {
        gridSize = 8;
        cellSize = 3;
        GridPaint();
        
    }

    private void OnDrawGizmos()
    {
        for (int y = 0; y < gridSize; y++)
        {
            for (int x = 0; x < gridSize; x++)
            {
                Gizmos.DrawWireCube(
                    new Vector3(gameObject.transform.position.x + (x * cellSize), gameObject.transform.position.y + (y * cellSize)), 
                    new Vector3(cellSize, cellSize));
            }
        }
    }

    public void GridPaint()
    {
        cellGrid = new CellCheck[gridSize, gridSize];
        for (int y = 0; y < gridSize; y++)
        {
            for (int x = 0; x < gridSize; x++)
            {
                CellCheck currentCell = Instantiate(cell);
                currentCell.transform.position = new Vector3(x * cellSize, y * cellSize);
                currentCell.transform.localScale = new Vector3(cellSize, cellSize);
                currentCell.transform.SetParent(gameObject.transform, true);
                currentCell.name = x + "_" + y;
                cellGrid[x, y] = currentCell;
            }
        }
    }
    public bool CanWalkOnCell(int x, int y)
    {
        return cellGrid[x, y].gridSpotTaken == false;
    }

}
