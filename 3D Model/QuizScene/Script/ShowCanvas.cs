using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowCanvas : MonoBehaviour
{
    public GameObject Canvas;

    public void OpenCanvas()
    {
        if (Canvas != null)
        {
            Canvas.SetActive(true);
        }
    }
  }
