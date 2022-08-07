using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EvidenceHandler : MonoBehaviour
{
    [Header("Evidences")]
    public int evidencesFound;
    public int requiredEvidences;

    [Header("UI")] 
    public bool isUIEnabled;
    public GameObject uiCanvas;
    public TMP_Text uiEvidencesText;

    [Header("Camera")]
    public Camera playerCamera;

    private void Start()
    {
        evidencesFound = 0;
        UpdateUI();
    }

    private void FixedUpdate()
    {
        RaycastHit hit;

        if (Physics.Raycast(playerCamera.transform.position, playerCamera.transform.forward, out hit, 10))
        {
            if (hit.collider.CompareTag("Evidence") && Input.GetKeyDown(KeyCode.E))
            {
                Destroy(hit.transform.gameObject);
                evidencesFound += 1;
                Debug.Log($"Evidence picked up, {requiredEvidences - evidencesFound} remaining.");
                UpdateUI();

                if (evidencesFound == requiredEvidences)
                {
                    Debug.Log("All Evidences found");
                    SceneManager.LoadScene("Scenes/LevelCompleted");
                }
            }
        }
    }

    private void UpdateUI()
    {
        if (isUIEnabled) uiEvidencesText.text = $"Found {evidencesFound} of {requiredEvidences} evidences";
    }
}
