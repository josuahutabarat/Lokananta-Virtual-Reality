using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloseCanvas : MonoBehaviour
{
    public GameObject Canvas;

    public void HideCanvas()
    {
        if (Canvas != null)
        {
            Canvas.SetActive(false);
        }
    }
}
