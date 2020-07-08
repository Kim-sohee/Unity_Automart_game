using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scriptclose : MonoBehaviour
{
    public GameObject panel;

    public void ClosePanel()
    {
        /*if (panel != null)
        {
            panel.SetActive(false);
        }*/
        panel.SetActive(false);
    }
}
