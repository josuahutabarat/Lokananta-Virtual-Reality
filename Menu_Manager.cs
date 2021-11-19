using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Menu_Manager : MonoBehaviour
{

    public GameObject MenuPanel;
    public GameObject PanduanPanel;

    // Start is called before the first frame update
    void Start()
    {
        MenuPanel.SetActive(true);
        PanduanPanel.SetActive(false);
    }

   
        public void MulaiClicked()
        {
            Application.LoadLevel("Scene1");
        }

        public void PanduanClicked()
        {
            MenuPanel.SetActive(false);
            PanduanPanel.SetActive(true);
        }

        public void Keluar_Clicked()
        {
            Application.Quit();
        }

    public void KembaliClicked()
    {
        MenuPanel.SetActive(true);
        PanduanPanel.SetActive(false);
    }
}
