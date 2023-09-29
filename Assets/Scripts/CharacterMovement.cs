
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
    public Vector3 playerCurrentPosition;
    public GridDrawScript gridDrawScript;
    

    private void Start()
    {
        PlayerStartingPosition();
    }

    private void Update()
    {
        PlayerMovement();
    }


    public void PlayerStartingPosition()
    {
        playerCurrentPosition = new Vector3(gridDrawScript.cellSize * 0, gridDrawScript.cellSize * 0, -1);
        gameObject.transform.position = playerCurrentPosition;
    }
    public void PlayerMovement()
    {

        if (Input.GetKeyDown(KeyCode.W) 
            && gameObject.transform.position.y < ((gridDrawScript.gridSize -1) * gridDrawScript.cellSize)
            && gridDrawScript.CanWalkOnCell((int)gameObject.transform.position.x / gridDrawScript.cellSize, ((int)gameObject.transform.position.y + gridDrawScript.cellSize) / gridDrawScript.cellSize)
            || Input.GetKeyDown(KeyCode.UpArrow) 
            && gameObject.transform.position.y < ((gridDrawScript.gridSize -1) * gridDrawScript.cellSize)
            && gridDrawScript.CanWalkOnCell((int)gameObject.transform.position.x / gridDrawScript.cellSize, ((int)gameObject.transform.position.y + gridDrawScript.cellSize) / gridDrawScript.cellSize))
        {
            gameObject.transform.position += gridDrawScript.cellSize * new Vector3(0, 1);
        }

        if (Input.GetKeyDown(KeyCode.S)
            && gameObject.transform.position.y > (0 * gridDrawScript.cellSize)
            && gridDrawScript.CanWalkOnCell((int)gameObject.transform.position.x / gridDrawScript.cellSize, ((int)gameObject.transform.position.y - gridDrawScript.cellSize) / gridDrawScript.cellSize)
            || Input.GetKeyDown(KeyCode.DownArrow)
            && gameObject.transform.position.y > (0 * gridDrawScript.cellSize)
            && gridDrawScript.CanWalkOnCell((int)gameObject.transform.position.x / gridDrawScript.cellSize, ((int)gameObject.transform.position.y - gridDrawScript.cellSize) / gridDrawScript.cellSize))
        {
            gameObject.transform.position += gridDrawScript.cellSize * new Vector3(0, -1);
        }

        if (Input.GetKeyDown(KeyCode.D) 
            && gameObject.transform.position.x < ((gridDrawScript.gridSize -1) * gridDrawScript.cellSize)
            && gridDrawScript.CanWalkOnCell(((int)gameObject.transform.position.x + gridDrawScript.cellSize) / gridDrawScript.cellSize, (int)gameObject.transform.position.y / gridDrawScript.cellSize)
            || Input.GetKeyDown(KeyCode.RightArrow) 
            && gameObject.transform.position.x < ((gridDrawScript.gridSize -1) * gridDrawScript.cellSize)
            && gridDrawScript.CanWalkOnCell(((int)gameObject.transform.position.x + gridDrawScript.cellSize) / gridDrawScript.cellSize, (int)gameObject.transform.position.y / gridDrawScript.cellSize))
        {
            gameObject.transform.position += gridDrawScript.cellSize * new Vector3(1, 0);
        }

        if (Input.GetKeyDown(KeyCode.A) 
            && gameObject.transform.position.x > (0 * gridDrawScript.cellSize)
            && gridDrawScript.CanWalkOnCell(((int)gameObject.transform.position.x - gridDrawScript.cellSize) / gridDrawScript.cellSize, (int)gameObject.transform.position.y / gridDrawScript.cellSize)
            || Input.GetKeyDown(KeyCode.LeftArrow) 
            && gameObject.transform.position.x > (0 * gridDrawScript.cellSize)
            && gridDrawScript.CanWalkOnCell(((int)gameObject.transform.position.x - gridDrawScript.cellSize) / gridDrawScript.cellSize, (int)gameObject.transform.position.y / gridDrawScript.cellSize))
        {
            gameObject.transform.position += gridDrawScript.cellSize * new Vector3(-1, 0);
        }

    }
}
