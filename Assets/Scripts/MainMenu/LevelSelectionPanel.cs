using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelSelectionPanel : MonoBehaviour
{
    [Header("Panels")] 
    public GameObject mainMenu;
    public GameObject mapSelection;
    
    public void handleBackBtn()
    {
        mainMenu.SetActive(true);
        mapSelection.SetActive(false);
    }
}
