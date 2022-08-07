using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenuPanel : MonoBehaviour
{
    [Header("Panels")] 
    public GameObject mainMenu;
    public GameObject mapSelection;
    
    public void handlePlayBtn()
    {
        mainMenu.SetActive(false);
        mapSelection.SetActive(true);
    }

    public void handleQuitBtn()
    {
        Application.Quit();
    }
}
