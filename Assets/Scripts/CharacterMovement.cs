using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
    public Vector3 playerCurrentPosition;
    public GridDrawScript gridDrawScript;

    private void Start()
    {
        playerCurrentPosition = new Vector3(gridDrawScript.cellSize * 4, gridDrawScript.cellSize * 1, -1);
        gameObject.transform.position = playerCurrentPosition;
    }

    private void Update()
    {
        PlayerMovement();
    }

    public void PlayerMovement()
    {
        
        if (Input.GetKeyDown(KeyCode.W) 
            && gameObject.transform.position.y < (gridDrawScript.gridSize * gridDrawScript.cellSize) 
            || Input.GetKeyDown(KeyCode.UpArrow) 
            && gameObject.transform.position.y < (gridDrawScript.gridSize * gridDrawScript.cellSize))
        {
            gameObject.transform.position += gridDrawScript.cellSize * new Vector3(0, 1);
        }
        if (Input.GetKeyDown(KeyCode.S) 
            && gameObject.transform.position.y > (1 * gridDrawScript.cellSize)
            || Input.GetKeyDown(KeyCode.DownArrow) 
            && gameObject.transform.position.y > (1 * gridDrawScript.cellSize))
        {
            gameObject.transform.position += gridDrawScript.cellSize * new Vector3(0, -1);
        }
        if (Input.GetKeyDown(KeyCode.D) 
            && gameObject.transform.position.x < (gridDrawScript.gridSize * gridDrawScript.cellSize) 
            || Input.GetKeyDown(KeyCode.RightArrow) 
            && gameObject.transform.position.x < (gridDrawScript.gridSize * gridDrawScript.cellSize))
        {
            gameObject.transform.position += gridDrawScript.cellSize * new Vector3(1, 0);
        }
        if (Input.GetKeyDown(KeyCode.A) 
            && gameObject.transform.position.x > (1 * gridDrawScript.cellSize)
            || Input.GetKeyDown(KeyCode.LeftArrow) 
            && gameObject.transform.position.x > (1 * gridDrawScript.cellSize))
        {
            gameObject.transform.position += gridDrawScript.cellSize * new Vector3(-1, 0);
        }

    }
}
