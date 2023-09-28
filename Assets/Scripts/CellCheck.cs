using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CellCheck : MonoBehaviour
{
    public bool gridSpotTaken;
    private void Update()
    {
        if (gridSpotTaken)
        {
            gameObject.GetComponent<SpriteRenderer>().color = Color.red;
        }
        else
        {
            gameObject.GetComponent<SpriteRenderer>().color = Color.blue;
        }
    }
}
