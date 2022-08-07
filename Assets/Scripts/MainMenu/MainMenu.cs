using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenu : MonoBehaviour
{
    [Header("Panels")] 
    public GameObject mainMenu;
    public GameObject mapSelection;
    
    void Start()
    {
        mainMenu.SetActive(true);
        mapSelection.SetActive(false);
    }
}
