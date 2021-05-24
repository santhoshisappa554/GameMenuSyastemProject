using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuControlManger : MonoBehaviour
{
    public GameObject optionPanel;
    public GameObject HelpPanel;
    public GameObject IntroPanel, Panel;
    // Start is called before the first frame update
    public void Optionmenu()
    {
        optionPanel.SetActive(true);
        IntroPanel.SetActive(false);
        Panel.SetActive(false);
    }
    public void Back()
    {
        optionPanel.SetActive(false);
        HelpPanel.SetActive(false);
        IntroPanel.SetActive(true);
        Panel.SetActive(true);
      
    }
    public void Helpmenu()
    {
        HelpPanel.SetActive(true);
        IntroPanel.SetActive(false);
        Panel.SetActive(false);
    }

}
